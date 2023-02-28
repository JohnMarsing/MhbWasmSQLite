using Fluxor;
using MhbWasmSQLite.Client.Components.BookChapterToolbar;
using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Features.Home;

public partial class Index
{
	[Inject] private IState<State>? State { get; set; }
}
