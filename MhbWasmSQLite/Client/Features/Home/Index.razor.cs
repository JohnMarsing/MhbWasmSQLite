using System.ComponentModel.DataAnnotations;
using Fluxor;
using MhbWasmSQLite.Client.Shared.Header;
using MhbWasmSQLite.Client.Shared.Header.Enums;
using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Features.Home;

public partial class Index
{
	[Inject] private IState<State>? State { get; set; }
}
