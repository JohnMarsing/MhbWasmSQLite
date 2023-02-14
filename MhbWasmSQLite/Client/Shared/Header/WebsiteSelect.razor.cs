using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Client.Shared.Header.Enums;
using MhbWasmSQLite.Client.Shared.Header.Stores;
using Fluxor;

namespace MhbWasmSQLite.Client.Shared.Header;

public partial class WebsiteSelect
{
	[Inject] private IState<ToolbarState> ToolbarState { get; set; }
	[Inject] public IDispatcher Dispatcher { get; set; }

	private string? selectedBibleWebsite = BibleWebsite.MyHebrewBible.Name;

	private bool IsSelectedBibleWebsite(string bibleWebsite)
	{
		return bibleWebsite == selectedBibleWebsite;
	}

	private void ChangingBibleWebsite(ChangeEventArgs e)
	{
		selectedBibleWebsite = e.Value.ToString();
		BibleWebsite bw = BibleWebsite.FromName((string)selectedBibleWebsite);

		var action = new SetBibleWebsiteAction(bw);
		Dispatcher.Dispatch(action);
	}

}
