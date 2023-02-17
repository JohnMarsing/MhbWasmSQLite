using Fluxor;
using MhbWasmSQLite.Client.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using MhbWasmSQLite.Shared;
using System.Reflection;
using MhbWasmSQLite.Client.Enums;

namespace MhbWasmSQLite.Client.Shared.Header;

// 1. Action
public record SetBibleBook_Action(Enums.BibleBook BibleBook);
//public record SetWebsite_Action(Enums.BibleWebsite BibleWebsite);
public record SetChapter_Action(int Chapter);
public record ShowDetails_Action(bool IsVisible);

public record GetVerses_Action(Enums.BibleBook BibleBook, int ChapterId);
public record GetVersesSuccess_Action(List<ScriptureVM> Scriptures); 
public record GetVersesFailure_Action(string ErrorMessage);
public record GetVersesWarning_Action(string WarningMessage); 

// 2. State
public record State
{
  public Enums.BibleBook? BibleBook { get; init; }
	public bool VisibleState { get; set; }
	public string? SuccessMessage { get; init; }
	public string? WarningMessage { get; init; }
	public string? ErrorMessage { get; init; }
	public int Chapter { get; init; }
	public List<ScriptureVM>? Scriptures { get; init; }
	//public bool ShowDetails { get; init; }
}

// 3. Feature
public class FeatureImplementation : Feature<State>
{
  public override string GetName() => "Header";

  protected override State GetInitialState()
  {
    return new State
    {
      // Don't set default BibleBook (e.g. Genesis) because we don't want <BibleSearch> to be collapsed from it's details
      Chapter = 1,
      //ShowDetails = false
			VisibleState = false,

    };
  }
}

// 4. Reducers
public static class Reducers
{
  [ReducerMethod]
  public static State OnSetBibleBook(
    State state,
    SetBibleBook_Action action)
  {
    return state with { BibleBook = action.BibleBook };
  }

  [ReducerMethod]
  public static State OnSetChapter(
    State state,
    SetChapter_Action action)
  {
    return state with { Chapter = action.Chapter };
  }

	/*
  [ReducerMethod]
  public static State OnShowDetails(
    State state, ShowDetails_Action action)
  {
    return state with { ShowDetails = action.IsVisible };
  }
	*/

	[ReducerMethod]
	public static State OnGetVersesSuccess(
		State state, GetVersesSuccess_Action action)
	{
		return state with
		{
			VisibleState = true,
			WarningMessage = string.Empty,
			ErrorMessage = string.Empty,
			Scriptures = action.Scriptures
		};
	}

	[ReducerMethod]
	public static State OnGetVersesWarning(
		State state, GetVersesWarning_Action action)
	{
		// Here might be a case where VisibleComponet has a .Table and 
		//  You got this warning (no records found) then set it to .None
		//  Therefore, this would be the only place where VisibleComponet = None
		return state with
		{
			//VisibleComponet = Enums.VisibleComponet.MasterList,
			VisibleState = false,
			WarningMessage = action.WarningMessage
		};
	}

	[ReducerMethod]
	public static State OnGetVersesFailure(
		State state, GetVersesFailure_Action action)
	{
		return state with { ErrorMessage = action.ErrorMessage };
	}
}

// 5. Effects
public class Effects
{
  #region Constructor and DI
  private readonly ILogger Logger;
  private IScriptureService svc;

  public Effects(ILogger<Effects> logger, IScriptureService scriptureService)
  {
    Logger = logger;
    svc = scriptureService;
  }
	#endregion

	[EffectMethod]
	public async Task GetVerses(GetVerses_Action action, IDispatcher dispatcher)
	{
		string inside = nameof(Effects) + "!" + nameof(GetVerses) + "!" + nameof(GetVerses_Action);
		Logger.LogDebug(string.Format("Inside {0}; Book/Chapter :{1} / {2}", inside, action.BibleBook.Value, action.ChapterId));
    try
    {
			List<ScriptureVM> Scriptures = new();
      await svc.GetByBookChapter(action.BibleBook, action.ChapterId);
			if (svc.Scriptures is not null)
			{
				dispatcher.Dispatch(new GetVersesSuccess_Action(svc.Scriptures));
			}
      else
      {
				Logger.LogWarning(string.Format("...{0}; {1} is null", inside, nameof(svc.Scriptures)));
				dispatcher.Dispatch(new GetVersesWarning_Action("No Special Events Found"));
			}
		}
		catch (Exception ex)
		{
			Logger.LogError(ex, string.Format("...Inside catch of {0}", inside));
			dispatcher.Dispatch(new GetVersesFailure_Action("An invalid operation occurred, contact your administrator."));
		}
	}
}