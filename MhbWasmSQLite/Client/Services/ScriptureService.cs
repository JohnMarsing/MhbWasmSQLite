using MhbWasmSQLite.Client.Shared;
using MhbWasmSQLite.Shared;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MhbWasmSQLite.Client.Components.BookChapterToolbar.Enums;

namespace MhbWasmSQLite.Client.Services;

public interface IScriptureService
{
	public List<ScriptureVM> Scriptures { get; set; }
	Task GetByBookChapter(BibleBook bibleBook, int chapterId);
	Task GetByVerses(int begId, int endId);
	Task<ScriptureVM> GetById(int id);  // 
	public List<VerseListVM> VerseList { get; set; }
}

public class ScriptureService : IScriptureService
{
	private HttpClient _http;
	private readonly ILogger<ScriptureService> _logger;
	public ScriptureService(HttpClient http, ILogger<ScriptureService> logger)
	{
		_http = http;
		_logger = logger;
	}

	public HttpClient? Http {get; }
	public List<ScriptureVM> Scriptures { get; set; } = new();

	public List<VerseListVM> VerseList { get; set; } = new();

	public async Task GetByBookChapter(BibleBook bibleBook, int chapterId)
	{
		string Uri = $"api/scripture/{bibleBook.Value}/{chapterId}";
		_logger.LogDebug(string.Format("Inside {0}; Uri: {1}"
			, nameof(ScriptureService) + "!" + nameof(GetByBookChapter), Uri));
		var result = await _http.GetFromJsonAsync<List<ScriptureVM>>(requestUri: Uri);
		
		if (result is not null)
		{
			Scriptures = result;
		}
	}

	public async Task GetByVerses(int begId, int endId) 
	{
		string Uri = $"api/versebyrange/{begId}/{endId}";
		_logger.LogDebug(string.Format("Inside {0}; Uri: {1}"
			, nameof(ScriptureService) + "!" + nameof(GetByVerses), Uri));
		var result = await _http.GetFromJsonAsync<List<VerseListVM>>(requestUri: Uri);

		if (result is not null)
		{
			VerseList = result;
		}
	}

	public Task<ScriptureVM> GetById(int id)
	{
		throw new NotImplementedException();
	}

}
