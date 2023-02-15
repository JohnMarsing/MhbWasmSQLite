using System.ComponentModel.DataAnnotations;
using MhbWasmSQLite.Client.Enums;

namespace MhbWasmSQLite.Client.Features.BibleSearch;

public partial class Index
{
	private FormValidation VM = new FormValidation();

	private async Task<IEnumerable<BibleBook>> SearchBibleBooks(string searchText)
	{
		return await Task.FromResult(BibleBook.List
			.Where(x => x.Title.ToLower().Contains(searchText.ToLower()))
			.OrderBy(o => o.Value));
	}

	private void HandleFormSubmit()  // Used only by Form
	{
		// ToDo: maybe log books searched?
	}

}

public class FormValidation
{
	[Required]
	[Display(Name = "Book")]
	public BibleBook SelectedBook { get; set; }

	public string MyHebrewBibleBookChapterUrl(int chapter)
	{
		return "https://myhebrewbible.com/BookChapter/" + SelectedBook.Title + "/" + chapter + "/slug";
	}

	public string MyHebrewBibleBookChapterTitle(int chapter)
	{
		return "MyHebrewBible.com/BookChapter/" + SelectedBook.Title + "/" + chapter;
	}

}

