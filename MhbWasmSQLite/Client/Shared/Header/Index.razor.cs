using Fluxor;
using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Shared.Header;

public partial class Index
{
	[Inject] private IState<State>? VersesState { get; set; }
	[Inject] public IDispatcher? Dispatcher { get; set; }

}

