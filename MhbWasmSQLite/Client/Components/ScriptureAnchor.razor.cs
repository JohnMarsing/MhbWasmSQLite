using MhbWasmSQLite.Client.Enums;
using MhbWasmSQLite.Client.Services;
using MhbWasmSQLite.Shared;
using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Components;

public partial class ScriptureAnchor
{
	[Parameter] public string? Text { get; set; }
	[Parameter] public int BegId { get; set; }
	[Parameter] public int EndId { get; set; }
	[Parameter] public string? Slug { get; set; }

	[Inject] private IScriptureService? svc { get; set; }
	[Inject] public ILogger<ScriptureAnchor>? Logger { get; set; }
	//[Inject] public IToastService? Toast { get; set; }

	protected Status _status;
	protected string _msg = string.Empty;

	List<ScriptureVM>? Scriptures;


	protected override async Task OnInitializedAsync()
	{
		/*
		Logger!.LogDebug(string.Format("Inside Page: {0}, Class!Method: {1}; CurrentFilter: {2}"
			, Page.Title, nameof(ScriptureAnchor) + "!" + nameof(OnInitializedAsync), CurrentFilter));
		*/
		await PopulateScriptures(1, 2);
	}

	private async Task PopulateScriptures(int begId, int endId)
	{
		try
		{
			_status = Status.Loading;
			await svc!.GetByBookChapter(Components.BookChapterToolbar.Enums.BibleBook.Genesis, endId);

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