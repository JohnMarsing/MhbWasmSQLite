using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace MhbWasmSQLite.Client.Features.FavoriteVerses;

public partial class DetailCard
{
	[Inject] public ILogger<DetailCard>? Logger { get; set; }

	private EnumsFV.Verses? CurrentVerse;

	private Type? selectedType;
	private void ButtonClick(EnumsFV.Verses verse)
	{
		selectedType = verse.Name?.ToString()?.Length > 0
			? Type.GetType($"MhbWasmSQLite.Client.Features.FavoriteVerses.DetailContent.{verse.Name}")
			: null;
		CurrentVerse = verse;
	}

}

/*
	[Parameter] public MediaQuery? MediaQuery { get; set; }
	[Parameter, EditorRequired] public bool IsXsOrSm { get; set; }

	[Parameter]	public string Title { get; set; }
	[Parameter] public RenderFragment ChildContent { get; set; }
	[Parameter] public EventCallback<MouseEventArgs> OnClickCallback { get; set; }
*/
