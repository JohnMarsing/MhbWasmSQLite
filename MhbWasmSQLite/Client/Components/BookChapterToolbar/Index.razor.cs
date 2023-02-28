using Fluxor;
using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Components.BookChapterToolbar;

public partial class Index
{
	[Inject] private IState<State>? State { get; set; }
	[Inject] public IDispatcher? Dispatcher { get; set; }

}

