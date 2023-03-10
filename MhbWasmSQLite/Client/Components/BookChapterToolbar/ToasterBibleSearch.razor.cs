using Microsoft.AspNetCore.Components;
using Blazored.Toast.Services;

namespace MhbWasmSQLite.Client.Components.BookChapterToolbar;

public partial class ToasterBibleSearch
{
	[Inject] public IToastService? Toast { get; set; }


	protected override void OnInitialized()
	{
		/*
		SubscribeToAction<ShowChapters_Action>(BibleDetails_ShowChapters_Toast);
		SubscribeToAction<ShowVerses_Action>(BibleDetails_ShowVersesIsVisible_Toast);
		SubscribeToAction<SetBibleBook_Action>(BibleDetails_SetBibleBook_Toast);
		SubscribeToAction<SetChapter_Action>(BibleDetails_SetChapter_Toast);
		SubscribeToAction<GetVerses_Action>(BibleDetails_GetVerse_Toast);

		SubscribeToAction<GetVersesSuccess_Action>(GetVersesSuccess_Toast);
		*/

		SubscribeToAction<GetVersesWarning_Action>(GetVersesWarning_Toast);
		SubscribeToAction<GetVersesFailure_Action>(GetVersesFailure_Toast);

		base.OnInitialized();
	}

	/*
	private void BibleDetails_ShowChapters_Toast(ShowChapters_Action action)
	{
		Toast!.ShowInfo($"BibleDetails!ShowChapters action; IsVisible: {action.IsVisible}");
	}
	private void BibleDetails_ShowVersesIsVisible_Toast(ShowVerses_Action action)
	{
		Toast!.ShowInfo($"BibleDetails!ShowVerses action; IsVisible: {action.IsVisible}");
	}
	private void BibleDetails_SetBibleBook_Toast(SetBibleBook_Action action)
	{
		if (action.BibleBook is not null)
		{
			Toast!.ShowInfo($"BibleDetails!SetBibleBook action, BibleBook: {action.BibleBook}");
		}
		else
		{
			Toast!.ShowInfo($"BibleDetails!SetBibleBook action, BibleBook: IS NULL");
		}
	}
	private void BibleDetails_SetChapter_Toast(SetChapter_Action action)
	{
		Toast!.ShowInfo($"BibleDetails!SetChapter action; Chapter: {action.Chapter}");
	}

	private void BibleDetails_GetVerse_Toast(GetVerses_Action action)
	{
		if (action.BibleBook is not null)
		{
			Toast!.ShowInfo($"BibleDetails!GetVerses action, BibleBook: {action.BibleBook}; ChapterId: {action.ChapterId}");
		}
		else
		{
			Toast!.ShowInfo($"BibleDetails!GetVerses action, BibleBook: IS NULL; ChapterId: {action.ChapterId}");
		}
	}

	private void GetVersesSuccess_Toast(GetVersesSuccess_Action action)
	{
		Toast!.ShowInfo($"Got list of {action.Scriptures.Count} records");
	}

	*/

	private void GetVersesWarning_Toast(GetVersesWarning_Action action)
	{
		Toast!.ShowWarning(action.WarningMessage);
	}
	private void GetVersesFailure_Toast(GetVersesFailure_Action action)
	{
		Toast!.ShowError($"{action.ErrorMessage}");
	}

}


