using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Blazored.Toast.Services;
using MhbWasmSQLite.Client.Services;
using MhbWasmSQLite.Shared;
using Page = MhbWasmSQLite.Client.Features.Lists.MenuItemConstants.Mitzvot;  // MhbWasmSQLite.Client.GlobalEnums.Link; //.Web.Pages.Parasha.LinkSmartEnums.ParashaLinks;
using MhbWasmSQLite.Client.Enums;
using MhbWasmSQLite.Client.Components.BookChapterToolbar.Enums;

namespace MhbWasmSQLite.Client.Features.Lists;

public partial class Mitzvot
{
	[Inject] private IBibleListService? Service { get; set; }
	[Inject] public ILogger<Mitzvot>? Logger { get; set; }
	[Inject] public IToastService? Toast { get; set; }
	
	//[Parameter, EditorRequired] public MhbWasmSQLite.Client.Components.BookChapterToolbar.Enums.BibleBook? BibleBook { get; set; }

	protected Status _status;
	protected string _msg = string.Empty;

	protected List<MhbWasmSQLite.Shared.Mitzvah>? MitzvahList;

	protected override async Task OnInitializedAsync()
	{
		Logger!.LogDebug(string.Format("Inside Page: {0}, Class!Method: {1}", Page.Title, nameof(Mitzvot) + "!" + nameof(OnInitializedAsync)));

		try
		{
			_status = Status.Loading;
			//MitzvahList = await Service!.GetMitzvotByTorahBookId(BibleBook);
			//await Service!.GetMitzvotByTorahBookId(BibleBook!);
      await Service!.GetMitzvotByTorahBookId(BibleBook.Deuteronomy);

      if (MitzvahList is null)  // || !String.IsNullOrEmpty(Service.UserInterfaceMessage))
			{
				//Toast.ShowWarning(Service.UserInterfaceMessage);
			}
			else
			{
				_status = Status.Loaded;
				MitzvahList = Service.Mitzvot;
			}

		}
		//catch (InvalidOperationException invalidOperationException)
		catch (Exception ex)
		{
			_status = Status.Error;
			_msg = ex.ToString();
			//Toast!.ShowError("Error");
		}
			//finally
		//{
		//	//TurnSpinnerOff = true;
		//}
	}

	/*
	 * 
private void PopulateButtonRows()
{
	try
	{
		_status = Status.Loading;

		_status = Status.Loaded;
	}
	catch (Exception ex)
	{
		_status = Status.Error;
		_msg = ex.ToString();
	}
}	 * 
			public async Task<ActionResult> OnGetAsync(TorahBook bookId = TorahBook.Genesis)
			{
				Mitzvot = new List<Mitzvah>();
				try
				{
					Mitzvot = await db.GetMitzvotByBookAsync((int)bookId);
					log.LogInformation($"Just called {nameof(db.GetMitzvotByBookAsync)}");
				}
				catch (Exception ex)
				{
					log.LogError(ex, $"Inside {nameof(OnGetAsync)}, {nameof(db.GetMitzvotByBookAsync)}");
					ExceptionMessage = ex.Message ?? "";
					return RedirectToPage(Anchors.Error.RedirectPageName);
				}
				return Page();
			}
	*/
}