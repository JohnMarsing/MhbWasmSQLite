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
	public class JotAndTittleController : ControllerBase
	{
		private readonly IConfiguration _config;
		private readonly ILogger<JotAndTittleController> _logger;
		public JotAndTittleController(IConfiguration config, ILogger<JotAndTittleController> logger)
		{
			_config = config;
			_logger = logger;
		}

		public string connectionId = "Default";
		public string SQL = "";
		public DynamicParameters? Parms { get; set; }

		IEnumerable<JotAndTittleVM>? jotAndTittles;

		[HttpGet]
		public async Task<ActionResult<List<JotAndTittleVM>>> GetAll()
		{
			_logger.LogInformation(string.Format("Inside {0}"
				, nameof(JotAndTittleController) + "!" + nameof(GetAll)));
			SQL = $@"
SELECT 
Id, ScriptureId, Verse, DescrHtml, Notes
FROM JotAndTittle
ORDER BY Id
LIMIT 200
";
			using IDbConnection conn = new SQLiteConnection(_config.GetConnectionString(connectionId));
			{
				jotAndTittles = await conn.QueryAsync<JotAndTittleVM>(SQL);
			}
			return Ok(jotAndTittles);
		}


		[HttpGet]
		[Route("{Id}")]
		public async Task<ActionResult<JotAndTittleVM>> GetById(int id)
		{
			Parms = new DynamicParameters(new { Id = id });
			SQL = $@"
--DECLARE @Id int =  1
SELECT 
Id, ScriptureId, Verse, DescrHtml, Notes
FROM JotAndTittle
WHERE Id = @Id
LIMIT 1
";
			using IDbConnection conn = new SQLiteConnection(_config.GetConnectionString(connectionId));
			{
				jotAndTittles = await conn.QueryAsync<JotAndTittleVM>(SQL, Parms);
			}

			if (jotAndTittles is null)
			{
				return NotFound(value: $"JotAndTittle Id: {id} not found");
			}
			else
			{
				return Ok(jotAndTittles);
			}
		}

	}
}

