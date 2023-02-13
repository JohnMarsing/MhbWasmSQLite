using MhbWasmSQLite.Shared;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dapper;
using System.Data;
using System.Data.SQLite;

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

		[HttpGet]
		public async Task<ActionResult<List<ScriptureVM>>> GetScriptures()
		{
			SQL = $@"
SELECT Id, BCV, BookID, Chapter, Verse, KJV, VerseOffset, DescH, DescD, DescHSlug
FROM Scripture
WHERE BookID=1
ORDER BY Id
LIMIT 50
";
			using IDbConnection conn = new SQLiteConnection(_config.GetConnectionString(connectionId));
			{
				scriptures = await conn.QueryAsync<ScriptureVM>(SQL);
			}
			return Ok(scriptures);
		}


		//[HttpGet("{ScriptureId}")]
		[HttpGet]
		[Route("{ScriptureId}")]
		public async Task<ActionResult<ScriptureVM>> GetScripture(int ScriptureId)
		{
			Parms = new DynamicParameters(new { Id = ScriptureId });
			SQL = $@"
--DECLARE @Id int =  1
SELECT Id, BCV, BookID, Chapter, Verse, KJV, VerseOffset, DescH, DescD, DescHSlug
FROM Scripture
WHERE Id = @ScriptureId
";
			using IDbConnection conn = new SQLiteConnection(_config.GetConnectionString(connectionId));
			{
				scriptures = await conn.QueryAsync<ScriptureVM>(SQL);
			}
			
			if (scriptures is null)
			{
				return NotFound(value: $"Scripture Id: {ScriptureId} not found");
			}
			else
			{
				return Ok(scriptures);
			}
		}

	}
}