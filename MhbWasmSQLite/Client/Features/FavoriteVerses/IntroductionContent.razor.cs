namespace MhbWasmSQLite.Client.Features.FavoriteVerses;

public partial class IntroductionContent
{
	private string Color => IsCollapsed ? "btn-primary" : "btn-primary";
	private string Title => IsCollapsed ? "Show" : "Hide";
	private string Icon => IsCollapsed ? "fas fa-chevron-down" : "fas fa-chevron-up";

	public bool IsCollapsed { get; set; } = true;
	protected void ToggleButtonClick(bool isCollapsed)
	{
		IsCollapsed = !isCollapsed;
	}
}
