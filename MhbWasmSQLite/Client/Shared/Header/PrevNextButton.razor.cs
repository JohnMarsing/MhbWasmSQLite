using MhbWasmSQLite.Client.Shared.Header.Enums;
using Microsoft.AspNetCore.Components;
using Fluxor;

namespace MhbWasmSQLite.Client.Shared.Header;

public partial class PrevNextButton
{
	[Inject] private IState<State>? State { get; set; }
	[Inject] public IDispatcher? Dispatcher { get; set; }

	protected void NavToBookChapter(bool isPrev )
	{
		int chapter;
		if (isPrev)
		{
			chapter = State!.Value.PrevNextButton!.PrevBibleBook!.Chapter;
			Dispatcher!.Dispatch(new SetBibleBook_Action(State!.Value.PrevNextButton!.PrevBibleBook!.BibleBook));
			Dispatcher!.Dispatch(new SetChapter_Action(chapter));
			Dispatcher!.Dispatch(new GetVerses_Action(State!.Value.PrevNextButton!.PrevBibleBook!.BibleBook!, chapter));
		}
		else
		{
			chapter = State!.Value.PrevNextButton!.NextBibleBook!.Chapter;
			Dispatcher!.Dispatch(new SetBibleBook_Action(State!.Value.PrevNextButton!.NextBibleBook!.BibleBook));
			Dispatcher!.Dispatch(new SetChapter_Action(chapter));
			Dispatcher!.Dispatch(new GetVerses_Action(State!.Value.PrevNextButton!.NextBibleBook!.BibleBook!, chapter));
		}
	}

	private void ClickClear()
	{
		Dispatcher!.Dispatch(new SetBibleBook_Action(null));
		Dispatcher!.Dispatch(new ShowChapters_Action(false));
		Dispatcher!.Dispatch(new ShowVerses_Action(false));
	}

}
