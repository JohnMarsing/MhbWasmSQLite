﻿using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Components;

public partial class ToggleVisibilityButton
{
		[Parameter] public RenderFragment? ChildContent { get; set; }

		[Parameter(CaptureUnmatchedValues = true)]
		public IReadOnlyDictionary<string, object> AdditionalAttributes { get; set; }
			= new Dictionary<string, object>() {
				{ "badgecolor", "bg-warning" },
				{ "buttoncolor", "btn-primary" },
				{ "buttonsize", "btn-sm" },
				{ "buttonfloat", "float-end" }
			};

		string? BadgeColor => AdditionalAttributes
			.TryGetValue("badgecolor", out var value) ? value.ToString() : string.Empty;

		string? ButtonColor => AdditionalAttributes
			.TryGetValue("buttoncolor", out var value) ? value.ToString() : string.Empty;

		string? ButtonSize => AdditionalAttributes
			.TryGetValue("buttonsize", out var value) ? value.ToString() : string.Empty;

		string? ButtonFloat => AdditionalAttributes
			.TryGetValue("buttonfloat", out var value) ? value.ToString() : string.Empty;

		//[Parameter] 	public string Title { get; set; }

		public EventCallback OnToggleClick { get; set; }

		public bool IsCollapsed { get; set; } = true;
		protected void Collapsed_ButtonClick()
		{
				IsCollapsed = !IsCollapsed;
		}
}
