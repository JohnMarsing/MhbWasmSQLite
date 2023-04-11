using Blazored.Toast.Services;
using MhbWasmSQLite.Client.Components.BookChapterToolbar;
using MhbWasmSQLite.Client.Enums;
using MhbWasmSQLite.Client.Features.Lists;
using MhbWasmSQLite.Client.Services;
using MhbWasmSQLite.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace MhbWasmSQLite.Client.Features.VerseList;

public partial class Index
{
	[Parameter] public string? Text { get; set; } = "Gen 1:1-2";
	[Parameter] public int BegId { get; set; } = 1;
	[Parameter] public int EndId { get; set; } = 2;
	[Parameter] public string? Slug { get; set; }

	[Inject] private IScriptureService? svc { get; set; }
	[Inject] public ILogger<Index>? Logger { get; set; }
	//[Inject] public IToastService? Toast { get; set; }

	protected Status _status;
	protected string _msg = string.Empty;

	protected override async Task OnInitializedAsync()
	{
		/*
		Logger!.LogDebug(string.Format("Inside Page: {0}, Class!Method: {1}; CurrentFilter: {2}"
			, Page.Title, nameof(Index) + "!" + nameof(OnInitializedAsync), CurrentFilter));
		*/
		await PopulateScriptures(1, 2);
	}

	private async Task PopulateScriptures(int begId, int endId)
	{
		try
		{
			_status = Status.Loading;
			await svc!.GetByVerses(begId, endId);

			if (svc!.Scriptures is null)
			{
				_msg = "Scriptures is null";
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
}