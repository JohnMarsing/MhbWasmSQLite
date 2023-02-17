using Microsoft.AspNetCore.Components;
using Blazored.Toast.Services;

namespace MhbWasmSQLite.Client.Shared.Header;

public partial class ToasterBibleSearch
{
	[Inject] public IToastService? Toast { get; set; }



	protected override void OnInitialized()
	{
		SubscribeToAction<ShowChapters_Action>(BibleDetails_ShowChapters_Toast);
		SubscribeToAction<ShowDetails_Action>(BibleDetails_ShowIsVisible_Toast);
		SubscribeToAction<SetBibleBook_Action>(BibleDetails_SetBibleBook_Toast);
		SubscribeToAction<SetChapter_Action>(BibleDetails_SetChapter_Toast);

		SubscribeToAction<GetVersesSuccess_Action>(GetVersesSuccess_Toast);
		SubscribeToAction<GetVersesWarning_Action>(GetVersesWarning_Toast);
		SubscribeToAction<GetVersesFailure_Action>(GetVersesFailure_Toast);

		base.OnInitialized();
	}

	private void BibleDetails_ShowChapters_Toast(ShowChapters_Action action)
	{
		Toast!.ShowInfo($"BibleDetails!ShowChapters action; IsVisible: {action.IsVisible}");
	}

	private void BibleDetails_ShowIsVisible_Toast(ShowDetails_Action action)
	{
		Toast!.ShowInfo($"BibleDetails!ShowDetails action; IsVisible: {action.IsVisible}");
	}

	private void BibleDetails_SetBibleBook_Toast(SetBibleBook_Action action)
	{
		Toast!.ShowInfo($"BibleDetails!SetBibleBook. action; BibleBook.Abrv: {action.BibleBook.Abrv}");
	}

	private void BibleDetails_SetChapter_Toast(SetChapter_Action action)
	{
		Toast!.ShowInfo($"BibleDetails!SetChapter action; Chapter: {action.Chapter}");
	}

	private void GetVersesSuccess_Toast(GetVersesSuccess_Action action)
	{
		Toast!.ShowInfo($"Got list of {action.Scriptures.Count} records");
	}
	private void GetVersesWarning_Toast(GetVersesWarning_Action action)
	{
		Toast!.ShowWarning($"No records found");
	}
	private void GetVersesFailure_Toast(GetVersesFailure_Action action)
	{
		Toast!.ShowError($"{action.ErrorMessage}");
	}

}


