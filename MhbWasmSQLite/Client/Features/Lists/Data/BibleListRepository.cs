using MhbWasmSQLite.Client.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using MhbWasmSQLite.Shared;
using System.Reflection;
using MhbWasmSQLite.Client.Enums;
using MhbWasmSQLite.Client.Components.BookChapterToolbar.Enums;

namespace MhbWasmSQLite.Client.Features.Lists.Data;

public class BibleListRepository
{
	#region Constructor and DI
	private readonly ILogger Logger;
	private IBibleListService svc;
	public List<MhbWasmSQLite.Shared.Mitzvah> MitzvahList { get; set; }

	public BibleListRepository(ILogger<BibleListRepository> logger, IBibleListService bibleListService)
	{
		Logger = logger;
		svc = bibleListService;
	}
	#endregion

	public async Task GetMitzvot(BibleBook bibleBook)
	{
		string inside = nameof(BibleListRepository) + "!" + nameof(GetMitzvot);
		string abrv = bibleBook != null ? bibleBook.Abrv : "NULL";

		Logger.LogDebug(string.Format("Inside {0}; BibleBook: {1}", inside, abrv));
		if (bibleBook is not null)
		{
			try
			{
				List<MhbWasmSQLite.Shared.Mitzvah> MitzvahList = new();
				await svc.GetMitzvotByTorahBookId(bibleBook);

				if (svc.Mitzvot is not null)
				{
					MitzvahList = svc.Mitzvot!;
				}
				else
				{
					Logger.LogWarning(string.Format("...{0}; {1} is null", inside, nameof(svc.Mitzvot)));
					//$"No Scriptures found for {bibleBook.BibleBook.Abrv}";
				}
			}
			catch (Exception ex)
			{
				Logger.LogError(ex, string.Format("...Inside catch of {0}", inside));
				//"An invalid operation occurred, contact your administrator.";
			}
		}
		else
		{
			//$"No BibleBook, abrv:{abrv}";
		}
	}

}
