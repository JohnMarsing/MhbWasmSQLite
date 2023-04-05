namespace MhbWasmSQLite.Client.Features.Lists;

public partial class Mitzvot
{
	/*
			public async Task<ActionResult> OnGetAsync(TorahBook bookId = TorahBook.Genesis)
			{
				Mitzvot = new List<Mitzvah>();
				try
				{
					Mitzvot = await db.GetMitzvotByBookAsync((int)bookId);
					log.LogInformation($"Just called {nameof(db.GetMitzvotByBookAsync)}");
				}
				catch (Exception ex)
				{
					log.LogError(ex, $"Inside {nameof(OnGetAsync)}, {nameof(db.GetMitzvotByBookAsync)}");
					ExceptionMessage = ex.Message ?? "";
					return RedirectToPage(Anchors.Error.RedirectPageName);
				}
				return Page();
			}
	*/
}