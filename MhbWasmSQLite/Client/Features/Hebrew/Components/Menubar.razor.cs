using MhbWasmSQLite.Client.Enums;
using MhbWasmSQLite.Client.Features.Hebrew.Enums;
using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Features.Hebrew.Components;

public partial class Menubar
{
	[Parameter, EditorRequired] public MenuItems? MenuItem { get; set; }
	public MenuItems? CurrentMenuItem { get; set; }

	//ToDo: This doesn't work
	public string ActiveFilter(MenuItems menuItem)  
	{
		if (menuItem == CurrentMenuItem)
		{
			return "active";
		}
		else
		{
			return "";
		}
	}
}
