using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Features.FavoriteVerses;

public partial class DetailCard
{
	[Inject] public ILogger<DetailCard>? Logger { get; set; }

	private Type? selectedType;
	private void ButtonClick(EnumsFV.Verses verse)
	{
		selectedType = verse.Name?.ToString()?.Length > 0
			? Type.GetType($"MhbWasmSQLite.Client.Features.FavoriteVerses.DetailContent.{verse.Name}")
			: null;
	}
}

