using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Client.Enums;

namespace MhbWasmSQLite.Client.Components;

public partial class PageHeader
{
	[Parameter, EditorRequired] public LinkEnum? Page { get; set; }
}