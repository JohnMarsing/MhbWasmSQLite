namespace MhbWasmSQLite.Client.Features.Lists.Enums;

public class JotAndTittle
{
	public int ID { get; set; }
	public int ScriptureID { get; set; }
	public string? Verse { get; set; }
	public string? HTMLFormatEng { get; set; }
	public string? Notes { get; set; }
	public string? Slug
	{
		get
		{
			return Verse!.Replace(" ", "-").Replace(":", "-").Replace(";", "-"); //
		}
	}
}
