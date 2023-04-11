using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Features.Lists.MitzvahPage;

public partial class Filter
{
	[Parameter] public Enums.TorahBookFilter? CurrentFilter { get; set; }
	[Parameter] public EventCallback<Enums.TorahBookFilter> OnFilterSelected { get; set; }

  private async Task OnClick(Enums.TorahBookFilter filter)
  {
    await OnFilterSelected.InvokeAsync(filter);
  }

	public string ActiveFilter(Enums.TorahBookFilter filter)
	{
		if (filter == CurrentFilter) { return "active"; }
		else { return ""; }
	}
}