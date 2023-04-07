namespace MhbWasmSQLite.Shared;

public class Mitzvah
{
	public int Id { get; set; }
	public int Detail { get; set; }
	public int BegId { get; set; }
	public int EndId { get; set; }
	public string? Verse { get; set; }
  public string? Descr { get; set; }
  public int BookId { get; set; }
	public string? BookAbrv { get; set; }
}
