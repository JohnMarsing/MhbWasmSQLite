﻿using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Features.Lists.Components;

public partial class BlurbCard
{
	[Parameter] public string? HeaderContent { get; set; }
	[Parameter, EditorRequired] public RenderFragment? ChildContent { get; set; }
}
