using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Client.Shared.Header.Enums;
using Fluxor;

namespace MhbWasmSQLite.Client.Shared.Header;

public partial class ChapterButtons
{
	[Inject] private IState<State>? State { get; set; }
	[Inject] public IDispatcher? Dispatcher { get; set; }

	[Parameter] public BibleBook? CurrentBibleBook { get; set; } 

	private void ButtonClick(int chapter)
	{
		Dispatcher!.Dispatch(new SetChapter_Action(chapter));
		Dispatcher!.Dispatch(new GetVerses_Action(CurrentBibleBook!, chapter)); 
	}

}

