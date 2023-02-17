using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Shared;
using MhbWasmSQLite.Client.Services;
using MhbWasmSQLite.Client.Enums;
using MhbWasmSQLite.Client.Shared.Header.Enums;
using Fluxor;
//using Fluxor;
//using Fluxor.Blazor.Web.Components;

namespace MhbWasmSQLite.Client.Shared.Header;

public partial class BookChapterDisplay
{
	//[Inject] public ILogger<BookChapterDisplay>? Logger { get; set; }
	[Inject] private IState<State>? VersesState { get; set; }
	[Inject] public IDispatcher? Dispatcher { get; set; }
}