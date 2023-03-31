using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Components;

public partial class LearnMoreToggleTemplate
{
	[Parameter] public RenderFragment? ChildContent { get; set; }

	public bool ContentIsShowing = false;
	private string Color => ContentIsShowing ? "btn-primary" : "btn-primary";
	private string Title => ContentIsShowing ? "Hide " : "Learn more...";
	private string Icon => ContentIsShowing ? "fas fa-chevron-up" : "fas fa-chevron-down";

	protected void LearnMoreToggleButtonClick()
	{
		ContentIsShowing = !ContentIsShowing;
	}

}
