using System.ComponentModel;

namespace MhbWasmSQLite.Client.Features.Hebrew;

public class HebrewChartPreSmartEnum
{
	[DisplayName("unicode")]
	public int UniInt { get; set; }

	[DisplayName("unicode name")]
	public string? UnicodeName { get; set; }

	[DisplayName("Hex")]
	public string? UniHex { get; set; }

	[DisplayName("sort")]
	public int SortOrder { get; set; }
	public string? Hebrew { get; set; }

	[DisplayName("eng.")]
	public string? EngLetter { get; set; }

	[DisplayName("gem.")]
	public int Gematria { get; set; }

	public int Strongs { get; set; }
	public string? Sofit { get; set; }

	[DisplayName("no dagesh")]
	public string? WithoutDagesh { get; set; }

	[DisplayName("prefix")]
	public string? PrefixMeaning { get; set; }

	[DisplayName("literal")]
	public string? LiteralMeaning { get; set; }

	[DisplayName("symbolic")]
	public string? SymbolicMeaning { get; set; }
	public int LetterCountUsage { get; set; }
	public string? Link { get; set; }
	public string? Comment { get; set; }

	[DisplayName("fn")]
	public string? Footnote { get; set; }

	[DisplayName("literal / symbolic")]
	public string LiteralAndSymbolicTwoLines
	{
		get { return LiteralMeaning + "<br />" + SymbolicMeaning; }
	}

}