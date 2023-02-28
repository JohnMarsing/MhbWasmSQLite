using Microsoft.AspNetCore.Components;
using Fluxor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MhbWasmSQLite.Client.Components.BookChapterToolbar.Enums;

namespace MhbWasmSQLite.Client.Components.BookChapterToolbar;

public partial class BibleSearch
{
  [Inject] private IState<State>? State { get; set; }
  [Inject] public IDispatcher? Dispatcher { get; set; }
	[Inject] public ILogger<BibleBook>? Logger { get; set; }
	
	protected override void OnInitialized()
	{ 
		base.OnInitializedAsync(); 
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
		
		Dispatcher!.Dispatch(new SetBibleBook_Action(bibleBook!));

		if (bibleBook is null)
    {
			Dispatcher!.Dispatch(new SetBibleBook_Action(null));
			Dispatcher!.Dispatch(new ShowChapters_Action(false));
			Dispatcher!.Dispatch(new ShowVerses_Action(false));
		}
		else
    {
			Dispatcher!.Dispatch(new ShowChapters_Action(true));
    }
  }
 
}
