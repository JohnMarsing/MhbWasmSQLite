using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Client.Shared.Header.Enums;
using Fluxor;
using MhbWasmSQLite.Client.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace MhbWasmSQLite.Client.Shared.Header;

public partial class BibleSearch
{
  [Inject] private IState<State>? BibleSearchState { get; set; }
  [Inject] public IDispatcher? Dispatcher { get; set; }
	[Inject] public ILogger<BibleBook>? Logger { get; set; }
	
  // protected override async Task OnInitializedAsync() { ... await Populate() ....}
	protected override void OnInitialized()
	{ 
		base.OnInitializedAsync(); // see Fluxor-needs-base.OnInitialized.md
	// base.OnInitializedAsync();
	}

	private async Task<IEnumerable<BibleBook>> SearchBibleBooks(string searchText)
  {
		//Logger!.LogDebug(string.Format("Inside {0}", "namespace:[" + nameof(Header) + "]!" +  nameof(BibleSearch) + "!" + nameof(SearchBibleBooks)));
		return await Task.FromResult(BibleBook.List
      .Where(x => x.Title.ToLower().Contains(searchText.ToLower()))
      .OrderBy(o => o.Value));
  }
  private void SelectedResultChanged(BibleBook bibleBook)
  {
		//string inside = "namespace:[" + nameof(Header) + "]!" + nameof(BibleSearch) + "!" + nameof(SelectedResultChanged);
		//Logger!.LogDebug(string.Format("Inside {0}; bibleBook.Abrv:{1}", inside, bibleBook.Abrv));

    if (bibleBook is null)
    {
      //Dispatcher!.Dispatch(new ShowDetails_Action(false));
			Dispatcher!.Dispatch(new ShowChapters_Action(false));
		}
    else
    {
			Dispatcher!.Dispatch(new ShowChapters_Action(true));
			//Dispatcher!.Dispatch(new ShowDetails_Action(true));
      Dispatcher!.Dispatch(new SetBibleBook_Action(bibleBook));
    }
  }
 
}
