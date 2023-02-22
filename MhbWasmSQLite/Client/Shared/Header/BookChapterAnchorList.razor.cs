using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Client.Shared.Header.Enums;
using Fluxor;

namespace MhbWasmSQLite.Client.Shared.Header;

public partial class BookChapterAnchorList
{
	/*	*/
	[Inject] private IState<State>? BibleSearchState { get; set; }
	[Inject] public IDispatcher? Dispatcher { get; set; }

	[Parameter] public BibleBook? CurrentBibleBook { get; set; } // = BibleBook.Genesis;

	//private BibleBook? CurrentBibleBook;
	//private int CurrentBibleBookId;

	//protected override void OnInitialized()
	//{		
	//	base.OnInitialized();
	//	//CurrentBibleBookId = BibleSearchState!.Value.BibleBook!.Value;
	//	CurrentBibleBook = BibleSearchState!.Value.BibleBook;

	//}

	private void Chapter_ButtonClick(int chapter)
	{
		Dispatcher!.Dispatch(new SetChapter_Action(chapter));
		Dispatcher!.Dispatch(new GetVerses_Action(CurrentBibleBook, chapter));  //BibleBook.Genesis, chapter));
		//Dispatcher!.Dispatch(new ShowDetails_Action(true));
		//Dispatcher!.Dispatch(new SetBibleBook_Action(bibleBook));
	}


}

