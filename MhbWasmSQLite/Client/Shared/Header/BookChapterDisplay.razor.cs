using Microsoft.AspNetCore.Components;
using Fluxor;

namespace MhbWasmSQLite.Client.Shared.Header;

public partial class BookChapterDisplay
{
	[Inject] private IState<State>? State { get; set; }
	[Inject] public IDispatcher? Dispatcher { get; set; }
}