using Microsoft.AspNetCore.Components;
using Fluxor;

namespace MhbWasmSQLite.Client.Components.BookChapterToolbar;

public partial class BookChapterDisplay
{
	[Inject] private IState<State>? State { get; set; }
	[Inject] public IDispatcher? Dispatcher { get; set; }
}