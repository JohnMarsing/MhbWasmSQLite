using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Client.GlobalEnums;

namespace MhbWasmSQLite.Client.Components;

public partial class PageHeaderGlobal
{
	[Parameter, EditorRequired] public Link? Page { get; set; }
}