using MhbWasmSQLite.Client.Features.Hebrew.Enums;
using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Features.Hebrew.Components;

public partial class MenubarMdLgXl
{
	[Parameter, EditorRequired] public MenuItems? MenuItem { get; set; }

	public MenuItems? CurrentMenuItem { get; set; }
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
