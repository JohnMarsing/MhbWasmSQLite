using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Client.Services;
using MhbWasmSQLite.Shared;

namespace MhbWasmSQLite.Client.Features.FavoriteVerses;

public partial class Index
{
	[Inject] public ILogger<Index>? Logger { get; set; }
	[Inject] public IScriptureService? svc { get; set; }

	public IList<FavoriteVerse>? Favorites { get; set; }

	//public FavoriteVerseCategory Category { get; set; }

}