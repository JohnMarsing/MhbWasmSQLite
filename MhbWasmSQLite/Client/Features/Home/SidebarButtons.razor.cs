using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Features.Home;

public partial class SidebarButtons
{
	[Parameter, EditorRequired] public bool IsXsOrSm { get; set; }
	
	protected string? TitleCSS;
	
	protected override void OnInitialized()
	{
		base.OnInitialized();
		TitleCSS = IsXsOrSm ? "h3 " : "h6";
	}
}