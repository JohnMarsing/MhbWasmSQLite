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

	public async Task GetMitzvot(Enums.TorahBookFilter filter)
	{
		string inside = nameof(BibleListRepository) + "!" + nameof(GetMitzvot);

		Logger.LogDebug(string.Format("Inside {0}; BibleBook: {1}", inside));
		if (filter is not null)
		{
			try
			{
				List<MhbWasmSQLite.Shared.Mitzvah> MitzvahList = new();
				await svc.GetMitzvotByTorahBookId(filter);

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
