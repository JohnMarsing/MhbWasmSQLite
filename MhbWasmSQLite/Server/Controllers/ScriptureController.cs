using MhbWasmSQLite.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dapper;
using System.Data;
using System.Data.SQLite;
using MhbWasmSQLite.Client.Services;

namespace MhbWasmSQLite.Server.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ScriptureController : ControllerBase
	{
		private readonly IConfiguration _config;
		private readonly ILogger<ScriptureController> _logger;
		public ScriptureController(IConfiguration config, ILogger<ScriptureController> logger)
		{
			_config = config;
			_logger = logger;
		}

		public string connectionId = "Default";
		public string SQL = "";
		public DynamicParameters? Parms { get; set; }

		IEnumerable<ScriptureVM>? scriptures;
		IEnumerable<VerseListVM>? verselist;

		[HttpGet]
		[Route("{bookId}/{chapterId:int}")]
		public async Task<ActionResult<List<ScriptureVM>>> GetBookChapter(int bookId, int chapterId)
		{

			_logger.LogInformation(string.Format("Inside {0}; bookId: {1}; chapterId: {2}"
				, nameof(ScriptureController) + "!" + nameof(GetBookChapter), bookId, chapterId));

			Parms = new DynamicParameters(new { BookID = bookId, Chapter = chapterId });
			SQL = $@"
--DECLARE @BookID int =  2, @Chapter=2
SELECT Id, BCV, BookID, Chapter, Verse, KJV, VerseOffset, DescH, DescD, DescHSlug
FROM Scripture
WHERE BookID=@BookID AND Chapter=@Chapter
ORDER BY Id
LIMIT 250
";
			using IDbConnection conn = new SQLiteConnection(_config.GetConnectionString(connectionId));
			{
				scriptures = await conn.QueryAsync<ScriptureVM>(SQL, Parms);
			}
			return Ok(scriptures);
		}


		[HttpGet]
		[Route("/verselist/{begId:int}/{endId:int}")]
		public async Task<ActionResult<List<VerseListVM>>> GetByVerses(int begId, int endId)
		{

			_logger.LogInformation(string.Format("Inside {0}; begId: {1}; endId: {2}"
				, nameof(ScriptureController) + "!" + nameof(GetByVerses), begId, endId));

			Parms = new DynamicParameters(new { BegId = begId, EndId = endId });
			SQL = $@"
--DECLARE @BegId int =  2, @EndId=2
SELECT Id, BCV, Verse, KJV, VerseOffset
FROM Scripture
WHERE Id >= @BegId AND Id <= @EndId
ORDER BY Id
LIMIT 250

";
			using IDbConnection conn = new SQLiteConnection(_config.GetConnectionString(connectionId));
			{
				verselist = await conn.QueryAsync<VerseListVM>(SQL, Parms);
			}
			return Ok(verselist);
		}


		//[HttpGet("{ScriptureId}")]
		[HttpGet]
		[Route("{ScriptureId}")]
		public async Task<ActionResult<ScriptureVM>> GetScripture(int scriptureId)
		{
			Parms = new DynamicParameters(new { Id = scriptureId });
			SQL = $@"
--DECLARE @Id int =  1
SELECT Id, BCV, BookID, Chapter, Verse, KJV, VerseOffset, DescH, DescD, DescHSlug
FROM Scripture
WHERE Id = @Id
";
			using IDbConnection conn = new SQLiteConnection(_config.GetConnectionString(connectionId));
			{
				scriptures = await conn.QueryAsync<ScriptureVM>(SQL, Parms);
			}
			
			if (scriptures is null)
			{
				return NotFound(value: $"Scripture Id: {scriptureId} not found");
			}
			else
			{
				return Ok(scriptures);
			}
		}

	}
}
//https://www.infoworld.com/article/3569369/how-to-use-attribute-routing-in-aspnet-core.html
