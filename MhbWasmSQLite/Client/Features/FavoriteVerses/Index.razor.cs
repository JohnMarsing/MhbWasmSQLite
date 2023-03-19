using Microsoft.AspNetCore.Components;
//using MhbWasmSQLite.Client.Services;
using MhbWasmSQLite.Client.Enums;

namespace MhbWasmSQLite.Client.Features.FavoriteVerses;

public partial class Index
{
	[Inject] public ILogger<Index>? Logger { get; set; }
	//[Inject] public IScriptureService? svc { get; set; }

	protected Status _status;
	protected string _msg = string.Empty;

	protected List<FavoriteVerse>? Favorites;

	protected override void OnInitialized()
	{
		base.OnInitialized();
		Logger!.LogDebug(string.Format("Inside {0}"
			, nameof(Index) + "!" + nameof(OnInitialized)));


		Favorites = FavoriteVersesFactory.GetAll().ToList();
		try
		{
			_status = Status.Loading;
			foreach (var item in Favorites)
			{
			}
			_status = Status.Loaded;
		}
		catch (Exception ex)
		{
			_status = Status.Error;
			_msg = ex.ToString();
		}
	}
}		

