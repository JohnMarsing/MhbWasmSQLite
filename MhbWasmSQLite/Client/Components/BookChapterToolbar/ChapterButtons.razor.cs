using Microsoft.AspNetCore.Components;
using Fluxor;
using MhbWasmSQLite.Client.Components.BookChapterToolbar.Enums;
using MhbWasmSQLite.Client.Enums;
using MhbWasmSQLite.Shared;
using Microsoft.Extensions.Logging;
using static System.Net.WebRequestMethods;

namespace MhbWasmSQLite.Client.Components.BookChapterToolbar;

public class ButtonRow
{
	public int ChapterStart { get; set; }
	public int ChapterEnd { get; set; }
}

public partial class ChapterButtons
{
	[Inject] private IState<State>? State { get; set; }
	[Inject] public IDispatcher? Dispatcher { get; set; }

	[Parameter] public BibleBook? CurrentBibleBook { get; set; }
	[Parameter, EditorRequired] public int ButtonsPerRow { get; set; }

	public List<ButtonRow> ButtonRows { get; set; } = new List<ButtonRow>();
	
	protected Status _status;
	protected string _msg = string.Empty;


	protected override void OnInitialized()
	{
		base.OnInitialized(); // see Fluxor-needs-base.OnInitialized.md
		PopulateButtonRows();
	}

	private void PopulateButtonRows()
	{
		try
		{
			_status = Status.Loading;

			if (ButtonsPerRow >= CurrentBibleBook!.LastChapter)
			{
				// Add only one row
				ButtonRows.Add(new ButtonRow()
				{
					ChapterStart = 1,
					ChapterEnd = CurrentBibleBook!.LastChapter
				});
			}
			else
			{
				// Multiple Rows
				int wholeRowCount = CurrentBibleBook!.LastChapter / ButtonsPerRow;
				int lastRowButtonCount = CurrentBibleBook!.LastChapter % ButtonsPerRow;
				int s = 1;
				int e = ButtonsPerRow;
				for (int r = 1; r <= wholeRowCount; r++)
				{

					ButtonRows.Add(new ButtonRow()
					{
						ChapterStart = s,
						ChapterEnd = e
					});
					s = e + 1;
					e += ButtonsPerRow;

				}

				if (lastRowButtonCount > 0)
				{
					ButtonRows.Add(new ButtonRow()
					{
						ChapterStart = (CurrentBibleBook!.LastChapter - lastRowButtonCount) + 1, // 50-5=45+1=46
						ChapterEnd = CurrentBibleBook!.LastChapter
					});

				}
			}
			_status = Status.Loaded;
		}
		catch (Exception ex)
		{
			_status = Status.Error;
			_msg = ex.ToString();
		}

	}

	private void ButtonClick(int chapter)
	{
		Dispatcher!.Dispatch(new SetChapter_Action(chapter));
		Dispatcher!.Dispatch(new GetVerses_Action(CurrentBibleBook!, chapter));
	}

	protected MarkupString ButtonNumber(int i) 
	{

		if (CurrentBibleBook!.LastChapter > 99)
		{
			if (i < 10)
			{
				return new MarkupString($"&nbsp;&nbsp;{i}");  // return new MarkupString($"&nbsp;{i}");
			}
			else
			{
				if (i < 100)
				{
					return new MarkupString($"&nbsp;{i}");
				}
				else
				{
					return new MarkupString($"{i}");
				}
			}

		}
		else
		{
			if (i < 10)
			{
				return new MarkupString($"&nbsp;{i}");  // return new MarkupString($"&nbsp;{i}");
			}
			else
			{
				return new MarkupString($"{i}");
			}
		}

	}

}
