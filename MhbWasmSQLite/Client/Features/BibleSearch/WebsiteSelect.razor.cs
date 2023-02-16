using Microsoft.AspNetCore.Components;
using Fluxor;

namespace MhbWasmSQLite.Client.Features.BibleSearch;

public partial class WebsiteSelect
{

  [Inject] private IState<State>? BibleSearchState { get; set; }
  [Inject] public IDispatcher? Dispatcher { get; set; }

  private string? selectedWebsite;

  protected override void OnInitialized()
  {
    selectedWebsite = BibleSearchState!.Value.BibleWebsite!.Name;
    base.OnInitialized();
  }

  private bool IsSelectedWebsite(string bibleWebsite)
  {
    return bibleWebsite == selectedWebsite;
  }

  private void ChangingBibleWebsite(ChangeEventArgs e)
  {
    selectedWebsite = e.Value?.ToString() ?? "";
    if (!String.IsNullOrEmpty(selectedWebsite))
    {
      Dispatcher!.Dispatch(new SetWebsite_Action(Enums.BibleWebsite.FromName(selectedWebsite)));
    }
    // else, I don't know why this would ever happen?
  }

}
