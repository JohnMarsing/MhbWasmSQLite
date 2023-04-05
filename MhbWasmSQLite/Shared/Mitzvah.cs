namespace MhbWasmSQLite.Shared;

//public enum TorahBook
//{
//	Genesis = 1,	
//	Exodus = 2,		
//	Leviticus = 3,
//	Numbers = 4,	
//	Deuteronomy = 5 
//}

public class Mitzvah
{
	public int Id { get; set; }
	public int Detail { get; set; }
	public int BegId { get; set; }
	public int EndId { get; set; }
	public string? Verse { get; set; }
	public int BookId { get; set; }
	public string? BookAbrv { get; set; }
	public string? Descr { get; set; }
}
