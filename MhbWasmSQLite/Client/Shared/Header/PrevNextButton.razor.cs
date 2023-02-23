using MhbWasmSQLite.Client.Shared.Header.Enums;
using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Shared;
using Fluxor;

namespace MhbWasmSQLite.Client.Shared.Header;

public partial class PrevNextButton
{
	[Inject] public IDispatcher? Dispatcher { get; set; }

	[Parameter] public BibleBook? CurrentBibleBook { get; set; }
	[Parameter] public int CurrentChapter { get; set; }

	protected	string? PrevText { get; set; }
	protected string? NextText { get; set; }

	//protected bool IsEnabled { get; set; }

	protected override void OnInitialized()
	{ 
		base.OnInitializedAsync(); // see Fluxor-needs-base.OnInitialized.md
		SetPrevBookChapter();
		SetNextBookChapter();
	}

	private void SetPrevBookChapter()
	{
		if (CurrentBibleBook!.Value == 1 & CurrentChapter == 1)
		{
			PrevText = ""; // Gen 1
			return;
		}

		if (CurrentChapter != 1)
		{
			PrevText = (CurrentChapter - 1).ToString();
		}
		else
		{
			BibleBook prev = BibleBook.FromValue(CurrentBibleBook.Value - 1);
			PrevText = $"{prev.Abrv} {prev.LastChapter}";
		}
	}

	private void SetNextBookChapter()
	{
		if (CurrentBibleBook!.Value == VerseFacts.LastBookInNT &
			  CurrentChapter == VerseFacts.LastChapterInNt)
		{
			NextText = ""; // Rev 22
			return;
		}

		if (CurrentChapter != CurrentBibleBook!.LastChapter)
		{
			NextText = (CurrentChapter + 1).ToString();
		}
		else
		{
			BibleBook next = BibleBook.FromValue(CurrentBibleBook.Value + 1);
			NextText = $"{next.Abrv} 1}";
		}
	}


	private void NavToBookChapter(bool isPrev )
	{
		if (isPrev)
		{
			Dispatcher!.Dispatch(new SetChapter_Action(chapter));
			Dispatcher!.Dispatch(new GetVerses_Action(CurrentBibleBook!, chapter));

			NextText = "?";
		}
		else
		{
			NextText = (CurrentChapter + 1).ToString();
		}
	}

}