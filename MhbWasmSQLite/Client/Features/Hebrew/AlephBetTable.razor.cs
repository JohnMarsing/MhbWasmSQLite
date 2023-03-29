using MhbWasmSQLite.Client.Enums;
using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Features.Hebrew;

public partial class AlephBetTable
{
  [Parameter] public MediaQuery? MediaQuery { get; set; }

  public List<Enums.HebrewChart>? HebrewChartList { get; set; }

  // protected override async Task OnInitializedAsync() { ... await Populate() ....}
  protected override void OnInitialized()
	{ 
		base.OnInitialized(); // see Fluxor-needs-base.OnInitialized.md
    HebrewChartList = Enums.HebrewChart.List.ToList();
  // base.OnInitializedAsync();
  }
}
