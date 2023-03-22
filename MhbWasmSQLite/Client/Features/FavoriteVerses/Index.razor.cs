using Microsoft.AspNetCore.Components;
//using MhbWasmSQLite.Client.Services;
using MhbWasmSQLite.Client.Enums;

namespace MhbWasmSQLite.Client.Features.FavoriteVerses;

public partial class Index
{
	[Inject] public ILogger<Index>? Logger { get; set; }

	private Type? selectedType;
	private void ButtonClick(EnumsFV.Verses	verse)
	{
		selectedType = verse.Name?.ToString()?.Length > 0 
			? Type.GetType($"MhbWasmSQLite.Client.Features.FavoriteVerses.DetailContent.{verse.Name}") 
			: null;
	}
}		

