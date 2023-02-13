namespace MhbWasmSQLite.Shared;

public class ScriptureVM
{
	public int ID { get; set; }
	//public string? BCV { get; set; }
	public string BCV { get; set; } = string.Empty;
	public byte BookID { get; set; }
	public byte Chapter { get; set; }
	public byte Verse { get; set; }
	public string? KJV { get; set; }
	public string? VerseOffset { get; set; }
	public string? DescH { get; set; }
	public string? DescD { get; set; }
	public string? DescHSlug { get; set; }
}

/*

	public string PartitionKey { get; set; }
	public string RowKey { get; set; }

		public bool IsInTaNaCh
		{
			get { if (ID <= VerseFacts.LastVerseInTaNaCh) return true; else return false; }
		}

		public string CV
		{
			get { return Chapter + ":" + Verse; }
		}

		public override string ToString() => $"{ID}: {BCV}   {BookID} - {Chapter} - {Verse}";

*/