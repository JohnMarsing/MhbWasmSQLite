namespace MhbWasmSQLite.Shared;

public class JotAndTittleVM
{
	public int Id { get; set; }
	public int ScriptureId { get; set; }
	public string? Verse { get; set; }
	public string? DescrHtml { get; set; }
	public string? Notes { get; set; }
	public string Slug => Verse.Replace(" ", "-").Replace(":", "-").Replace(";", "-"); 
}

