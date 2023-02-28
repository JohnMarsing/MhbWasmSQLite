using MhbWasmSQLite.Client.Components.BookChapterToolbar.Enums;
using MhbWasmSQLite.Shared;

namespace MhbWasmSQLite.Client.Components.BookChapterToolbar;

public class PrevNextButtonVM
{
	public BookChapterPrevNext? PrevBibleBook { get; set; }
	public BookChapterPrevNext? NextBibleBook { get; set; }

	public PrevNextButtonVM(BibleBook CurrentBibleBook, int CurrentChapter)
	{
		PrevBibleBook = SetPrevBookChapter(CurrentBibleBook, CurrentChapter);
		NextBibleBook = SetNextBookChapter(CurrentBibleBook, CurrentChapter);
	}

	private BookChapterPrevNext SetPrevBookChapter(BibleBook CurrentBibleBook, int CurrentChapter)
	{
		BookChapterPrevNext bc = new("fas fa-arrow-left");

		if (CurrentBibleBook!.Value == BibleBook.Genesis.Value & CurrentChapter == 1)
		{
			bc.BibleBook = null;
			bc.ButtonText = null;
			return bc; 
		}

		if (CurrentChapter != 1)
		{
			bc.BibleBook = CurrentBibleBook;
			bc.Chapter = CurrentChapter - 1;
			bc.ButtonText = bc.Chapter.ToString();
		}
		else  
		{
			bc.BibleBook = BibleBook.FromValue(CurrentBibleBook.Value - 1);
			bc.Chapter = bc.BibleBook.LastChapter;
			bc.ButtonText = $"{bc.BibleBook.Abrv} {bc.Chapter}";
		}
		return bc;
	}

	private BookChapterPrevNext  SetNextBookChapter(BibleBook CurrentBibleBook, int CurrentChapter)
	{
		BookChapterPrevNext bc = new("fas fa-arrow-right");

		if (CurrentBibleBook!.Value == VerseFacts.LastBookInNT &
				CurrentChapter == VerseFacts.LastChapterInNt)
		{
			bc.BibleBook = null;
			bc.ButtonText = null;
			return bc; // Rev 22
		}

		if (CurrentChapter != CurrentBibleBook!.LastChapter)
		{
			bc.BibleBook = CurrentBibleBook;
			bc.Chapter = CurrentChapter + 1;
			bc.ButtonText = bc.Chapter.ToString();
		}
		else
		{
			bc.BibleBook = BibleBook.FromValue(CurrentBibleBook.Value + 1);
			bc.Chapter = 1;
			bc.ButtonText = $"{bc.BibleBook.Abrv} {bc.Chapter}";
		}
		return bc;

	}

}

public class BookChapterPrevNext
{
	public string Icon { get; set; }
	public BibleBook? BibleBook { get; set; }
	public string? ButtonText { get; set; }
	public int Chapter { get; set; }
	public bool ThereIsNone {  get  {	return BibleBook == null ? true : false;	}	}
	
	public BookChapterPrevNext(string icon)
	{
		Icon = icon;
	}
}