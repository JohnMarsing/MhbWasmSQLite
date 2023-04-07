using MhbWasmSQLite.Shared;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data;
using System.Data.SQLite;

namespace MhbWasmSQLite.Server.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class MitzvotController : ControllerBase
	{
		private readonly IConfiguration _config;
		private readonly ILogger<MitzvotController> _logger;
		public MitzvotController(IConfiguration config, ILogger<MitzvotController> logger)
		{
			_config = config;
			_logger = logger;
		}

		public string connectionId = "Default";
		public string SQL = "";
		public DynamicParameters? Parms { get; set; }

		IEnumerable<Mitzvah>? mitzvot;

		[HttpGet]
		[Route("book/{bookId}")]
		public async Task<ActionResult<List<Mitzvah>>> GetByTorahBookId(int bookId)
		{

			_logger.LogInformation(string.Format("Inside {0}; bookId: {1}"
				, nameof(MitzvotController) + "!" + nameof(GetByTorahBookId), bookId));

			if (bookId == 0)
			{
				SQL = $@"
SELECT 
Id, Detail, BegId, EndId, Verse, Descr, BookId, BookAbrv
FROM Mitzvot
ORDER BY Id
LIMIT 800
";
				using IDbConnection conn = new SQLiteConnection(_config.GetConnectionString(connectionId));
				{
					mitzvot = await conn.QueryAsync<Mitzvah>(SQL);
				}
				return Ok(mitzvot);
			}
			else
			{
				Parms = new DynamicParameters(new { BookId = bookId });
				SQL = $@"
SELECT 
Id, Detail, BegId, EndId, Verse, Descr, BookId, BookAbrv
FROM Mitzvot
WHERE BookId=@BookId
ORDER BY Id
LIMIT 800
";
				using IDbConnection conn = new SQLiteConnection(_config.GetConnectionString(connectionId));
				{
					mitzvot = await conn.QueryAsync<Mitzvah>(SQL, Parms);
				}
				return Ok(mitzvot);
			}

		}


		[HttpGet]
		[Route("/id/{MitzvahId}")]
		public async Task<ActionResult<Mitzvah>> GetById(int mitzvahId)
		{
			Parms = new DynamicParameters(new { Id = mitzvahId });
			SQL = $@"
--DECLARE @Id int =  1
SELECT 
Id, Detail, BegId, EndId, Verse, Descr, BookId, BookAbrv
FROM Mitzvot
WHERE Id = @Id
LIMIT 1
";
			using IDbConnection conn = new SQLiteConnection(_config.GetConnectionString(connectionId));
			{
				mitzvot = await conn.QueryAsync<Mitzvah>(SQL, Parms);
			}

			if (mitzvot is null)
			{
				return NotFound(value: $"Mitzvah Id: {mitzvahId} not found");
			}
			else
			{
				return Ok(mitzvot);
			}
		}

  }
}

