using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Shared;
using MhbWasmSQLite.Client.Services;
using MhbWasmSQLite.Client.Enums;
//using Fluxor;
//using Fluxor.Blazor.Web.Components;

namespace MhbWasmSQLite.Client.Shared.Header;

public partial class BookChapterDisplay
{
	[Inject] public IScriptureService svc { get; set; }
	[Inject] public ILogger<BookChapterDisplay>? Logger { get; set; }

	[Parameter, EditorRequired] public BibleBook? BibleBook { get; set; } // = BibleBook.Exodus;
	[Parameter, EditorRequired] public int ChapterId { get; set; }

	Status _status;
	string _msg = string.Empty;

	protected override async Task OnInitializedAsync()
	{
		try
		{
			_status = Status.Loading;
			Logger!.LogInformation("...Calling svc.GetByBookChapter");

			//scriptures = await svc.GetByBookChapter(bibleBook);
			await svc.GetByBookChapter(BibleBook, ChapterId);
			if (svc.Scriptures is not null)
			{
				_status = Status.Loaded;
			}
		}
		catch (Exception ex)
		{
			_status = Status.Error;
			_msg = ex.ToString();
			Logger!.LogError(ex, "...Exception occurred");
		}
	}

}