using MhbWasmSQLite.Client.Shared;
using MhbWasmSQLite.Shared;
using MhbWasmSQLite.Client.Enums;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MhbWasmSQLite.Client.Services;

public interface IScriptureService
{
	public List<ScriptureVM> Scriptures { get; set; }
	//Task<List<ScriptureVM>> GetByBookChapter(int id);
	Task GetByBookChapter(BibleBook bibleBook, int chapterId);
	Task<ScriptureVM> GetById(int id);  // 
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

	//public Task<List<ScriptureVM>> GetByBookChapter(int id)
	public async Task GetByBookChapter(BibleBook bibleBook, int chapterId)
	{
		
		var result = await _http.GetFromJsonAsync<List<ScriptureVM>>(requestUri: "api/scripture");
		if (result is not null)
		{
			Scriptures = result;
		}
	}

	public Task<ScriptureVM> GetById(int id)
	{
		throw new NotImplementedException();
	}

}
