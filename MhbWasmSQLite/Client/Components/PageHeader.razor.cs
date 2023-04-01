using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Client.GlobalEnums;

namespace MhbWasmSQLite.Client.Components;

public partial class PageHeader
{
	[Parameter, EditorRequired] public Link? Page { get; set; }
}