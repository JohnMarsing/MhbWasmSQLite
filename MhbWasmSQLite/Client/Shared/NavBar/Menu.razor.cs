using Microsoft.AspNetCore.Components;

namespace MhbWasmSQLite.Client.Shared.NavBar;

public partial class Menu
{

  bool collapseMenu = true;
  string CssClass => collapseMenu ? "collapse" : string.Empty;
  void ToggleMenu()
  {
    collapseMenu = !collapseMenu;
  }

  [Parameter]
  public bool UseDarkMode { get; set; } = false;

  string? Color;
  string? TextColor;

  protected override async Task OnInitializedAsync()
  {
    await Task.Delay(0);
    Color = UseDarkMode ? " navbar-dark bg-dark " : " navbar-light bg-white ";
    TextColor = UseDarkMode ? " text-white " : " text-dark ";
  }
}