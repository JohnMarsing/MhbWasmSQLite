using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Features.Hebrew.Components;

public partial class SubNavBar
{
	bool collapseNavMenu = true;
	string? SubNavBarCssClass => collapseNavMenu ? "collapse" : null;
	void ToggleSubNavBar()
	{
		collapseNavMenu = !collapseNavMenu;
	}

	// ToDo: review this note because `Display` isn't being used
	//   Can't force EditorRequired because PrintTable is set to `Display=> false`
	[Parameter] public MenuItems? ActiveMenuItem { get; set; }
	
	// ToDo: this was here to theme switching to dark mode which has not happen yet, 
	//   this could just be hard coded in SubNavBar.razor 
	protected string NavBarColor = " navbar-light bg-light ";  

	string GetActive(MenuItems currentMenuItem)
	{
		return ActiveMenuItem == currentMenuItem ? " active" : "";
	}

}
