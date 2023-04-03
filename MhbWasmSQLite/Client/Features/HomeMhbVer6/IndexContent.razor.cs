using MhbWasmSQLite.Client.Enums;
using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Features.HomeMhbVer6;

public partial class IndexContent
{
	[Parameter] public MediaQuery MediaQuery { get; set; } = MediaQuery.SmOrMdOrLgOrXl;

	protected string? panelClass;
	protected string? initialyMakePanelOpen;  

	protected string? TitleCSS;

	protected override void OnInitialized()
	{
		base.OnInitialized();
		panelClass = MediaQuery == MediaQuery.Xs ? "panel panel-info " : "";
		initialyMakePanelOpen = MediaQuery == MediaQuery.Xs ? " " : " in"; // if this = " in" then it will be openned
	}
}

