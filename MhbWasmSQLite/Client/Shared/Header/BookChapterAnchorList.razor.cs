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
		Dispatcher!.Dispatch(new GetVerses_Action(BibleBook.Genesis, chapter));

	}



}

