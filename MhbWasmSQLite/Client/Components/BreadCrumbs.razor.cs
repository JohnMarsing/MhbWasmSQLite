using MhbWasmSQLite.Client.Enums;
using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Components;

public partial class BreadCrumbs
{
	[Parameter] public string? Href { get; set; }
	[Parameter] public string? ParentTitle { get; set; }
	[Parameter] public string? Title { get; set; }
	//[Parameter] public string? Icon { get; set; }
	[Parameter] public MarkupString IconMarkup { get; set; }
	[Parameter, EditorRequired] public LinkEnum? ParentPage { get; set; }

	protected bool IsValid;

	protected override Task OnInitializedAsync()
	{
		if (!String.IsNullOrWhiteSpace(Href))
		{
			IsValid = true;
		}
		else
		{
			IsValid = false;
		}

		if (String.IsNullOrWhiteSpace(ParentTitle))
		{
			ParentTitle = "???";
		}

		if (String.IsNullOrWhiteSpace(Title))
		{
			Title = "???";
		}

		return base.OnInitializedAsync();
	}
}
