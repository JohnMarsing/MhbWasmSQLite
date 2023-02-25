using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Client.Enums;

namespace MhbWasmSQLite.Client.Features.Home;

public partial class Intro
 {
	[Parameter] public MediaQuery? MediaQuery { get; set; }
}