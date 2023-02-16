using Fluxor;

namespace MhbWasmSQLite.Client.Shared.Header;

// 1. Action
public record SetBibleBook_Action(Enums.BibleBook BibleBook);
//public record SetWebsite_Action(Enums.BibleWebsite BibleWebsite);
public record SetChapter_Action(int Chapter);
public record ShowDetails_Action(bool IsVisible);

// 2. State
public record State
{
  public Enums.BibleBook? BibleBook { get; init; }
  public int Chapter { get; init; }
  public bool ShowDetails { get; init; }
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
      ShowDetails = false
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

  [ReducerMethod]
  public static State OnShowDetails(
    State state, ShowDetails_Action action)
  {
    return state with { ShowDetails = action.IsVisible };
  }


}

// 5. Effects

