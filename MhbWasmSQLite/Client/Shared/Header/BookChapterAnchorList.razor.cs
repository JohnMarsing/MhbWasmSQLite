using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Client.Shared.Header.Enums;
using Fluxor;

namespace MhbWasmSQLite.Client.Shared.Header;

public partial class BookChapterAnchorList
{
	/*	*/
	[Inject] private IState<State>? BibleSearchState { get; set; }
	[Inject] public IDispatcher? Dispatcher { get; set; }

	private void Chapter_ButtonClick(int chapter)
	{
		Dispatcher!.Dispatch(new SetChapter_Action(chapter));
		Dispatcher!.Dispatch(new GetVerses_Action(BibleBook.Genesis, chapter));
		//Dispatcher!.Dispatch(new ShowDetails_Action(true));
		//Dispatcher!.Dispatch(new SetBibleBook_Action(bibleBook));
	}



}

