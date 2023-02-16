using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Client.Shared.Header.Enums;
using Fluxor;

namespace MhbWasmSQLite.Client.Shared.Header;

public partial class BookChapterAnchorList
{
	[Inject] private IState<State>? BibleSearchState { get; set; }

	protected string AnchorBookChapterUrl(int chapter)
	{
		if (BibleSearchState!.Value.Chapter == BibleWebsite.MyHebrewBible)
		{
			return $"{BibleWebsite.MyHebrewBible.UrlBase}{BibleSearchState.Value.BibleBook.Title}/{chapter}{UrlSuffix(true)}";
		}
		else
		{
		}
	}

}

