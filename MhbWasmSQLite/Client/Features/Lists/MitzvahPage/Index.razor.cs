using Microsoft.AspNetCore.Components;
using Blazored.Toast.Services;
using Page = MhbWasmSQLite.Client.Features.Lists.MenuItemConstants.Mitzvot;
using MhbWasmSQLite.Client.Enums;

namespace MhbWasmSQLite.Client.Features.Lists.MitzvahPage;


public partial class Index
{
	[Inject] private IBibleListService? Service { get; set; }
	[Inject] public ILogger<Index>? Logger { get; set; }
	[Inject] public IToastService? Toast { get; set; }

	public Enums.TorahBookFilter CurrentFilter { get; set; } = Enums.TorahBookFilter.Genesis;

	private async Task HandleFilterSelected(Enums.TorahBookFilter selectedFilter)
	{
		CurrentFilter = selectedFilter;
		await PopulateMitzvot(selectedFilter);
	}


	protected override async Task OnInitializedAsync()
	{
		Logger!.LogDebug(string.Format("Inside Page: {0}, Class!Method: {1}; CurrentFilter: {2}"
			, Page.Title, nameof(Index) + "!" + nameof(OnInitializedAsync), CurrentFilter));
		await PopulateMitzvot(CurrentFilter);
	}


	private async Task PopulateMitzvot(Enums.TorahBookFilter filter)
	{
		try
		{
			_status = Status.Loading;
			await Service!.GetMitzvotByTorahBookId(CurrentFilter);
			if (Service!.Mitzvot is null)
			{
				_msg = "Mitzvot is null";
			}
			else
			{
				_status = Status.Loaded;
			}
		}
		catch (Exception ex)
		{
			_status = Status.Error;
			_msg = ex.ToString();
		}
	}

	protected Status _status;
	protected string _msg = string.Empty;

}