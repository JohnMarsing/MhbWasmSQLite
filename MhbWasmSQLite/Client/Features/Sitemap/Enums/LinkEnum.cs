using Ardalis.SmartEnum;

namespace MhbWasmSQLite.Client.Features.Sitemap.Enums;

public abstract class LinkEnum : SmartEnum<LinkEnum>
{
	#region Id's
	private static class Id
	{
		internal const int ParashaCurrent = 1;
		/*
				internal const int BookChapter = 2;
				internal const int VerseList = 3;
				internal const int VersesCsv = 4;
		*/
		internal const int Article = 5;
		internal const int FavoriteVerses = 6;
		internal const int Hebrew = 7;
		internal const int AlephTavs = 8;
		internal const int BibleList = 9;
		internal const int Teaching = 10;
		internal const int Sitemap = 11;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly LinkEnum ParashaCurrent = new ParashaCurrentSE();

	/*
	public static readonly LinkEnum BookChapter = new BookChapterSE();
	public static readonly LinkEnum VerseList = new VerseListSE();
	public static readonly LinkEnum VersesCsv = new VersesCsvSE();
*/
	public static readonly LinkEnum Article = new ArticleSE();
	public static readonly LinkEnum FavoriteVerses = new FavoriteVersesSE();
	public static readonly LinkEnum Hebrew = new HebrewSE();
	public static readonly LinkEnum AlephTavs = new AlephTavsSE();
	public static readonly LinkEnum BibleList = new BibleListSE();
	public static readonly LinkEnum Teaching = new TeachingSE();
	public static readonly LinkEnum Sitemap = new SitemapSE();
	#endregion

	private LinkEnum(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Index { get; }
	public abstract string Title { get; }
	public abstract string Icon { get; }
	public abstract string ShortTitle { get; }
	public abstract string HomeTitleSuffix { get; }
	public abstract string HomeFloatRightHebrew { get; }

	/*
	ToDo: add something like DisplayBitWise
	public abstract bool SitemapUsage { get; }
	public abstract bool HomeSidebarUsage { get; }
	*/
	
	//public string Dump { get  {	return $" {Value}-{Index}-{Title}"; } }
	#endregion

	#region Private Instantiation
	private sealed class ParashaCurrentSE : LinkEnum
	{
		public ParashaCurrentSE() : base($"{nameof(Id.ParashaCurrent)}", Id.ParashaCurrent) { } 
		public override string Index => "Parasha";
		public override string Title => "Parasha";
		public override string Icon => "far fa-bookmark";
		public override string ShortTitle => "";
		public override string HomeTitleSuffix => " Parashat H6567";
		public override string HomeFloatRightHebrew => "פָּרָשַׁת";
	}

	/*
	private sealed class BookChapterSE : LinkEnum
	{
		public BookChapterSE() : base($"{nameof(Id.BookChapter)}", Id.BookChapter) { }
		public override string Index => "BookChapter";
		public override string Title => "Book Chapter";
		public override string Icon => "far fa-bookmark";
		public override string ShortTitle => ""; 
		public override string HomeTitleSuffix => " Torah H8451";
		public override string HomeFloatRightHebrew => "תּוֹרָה";
	}
	private sealed class VerseListSE : LinkEnum
	{
		public VerseListSE() : base($"{nameof(Id.VerseList)}", Id.VerseList) { }
		public override string Index => "VerseList";
		public override string Title => "Verse List";
		public override string Icon => "fas fa-list";
		public override string ShortTitle => "";
		public override string HomeTitleSuffix => " mispar h4557";
		public override string HomeFloatRightHebrew => "מִסְפָּר";
	}

	private sealed class VersesCsvSE : LinkEnum
	{
		public VersesCsvSE() : base($"{nameof(Id.VersesCsv)}", Id.VersesCsv) { }
		public override string Index => "VersesCsv";
		public override string Title => "Multi Verses Lookup";
		public override string Icon => "fas fa-torah";
		public override string ShortTitle => "Multi Verses Lookup by C.S.V. (comma separated values)";
		public override string HomeTitleSuffix => " mispar h4557";
		public override string HomeFloatRightHebrew => "מִסְפָּר";
	}
	*/

	private sealed class ArticleSE : LinkEnum
	{
		public ArticleSE() : base($"{nameof(Id.Article)}", Id.Article) { }
		public override string Index => "Articles";
		public override string Title => "Articles";
		public override string Icon => "far fa-newspaper";
		public override string ShortTitle => "";
		public override string HomeTitleSuffix => " Ketuvim H3789";
		public override string HomeFloatRightHebrew => "כְּתֻבִים";
	}

	private sealed class FavoriteVersesSE : LinkEnum
	{
		public FavoriteVersesSE() : base($"{nameof(Id.FavoriteVerses)}", Id.FavoriteVerses) { }
		public override string Index => "FavoriteVerses";
		public override string Title => "Favorite Verses";
		public override string Icon => "text-danger fas fa-star";
		public override string ShortTitle => "";
		public override string HomeTitleSuffix => " Avah H183";
		public override string HomeFloatRightHebrew => "אָוָה";
	}

	private sealed class HebrewSE : LinkEnum
	{
		public HebrewSE() : base($"{nameof(Id.Hebrew)}", Id.Hebrew) { }
		public override string Index => "Hebrew";
		public override string Title => "Hebrew";  //Hebrew Charts
		public override string Icon => "fa-letter-aleph-bet";
		public override string ShortTitle => "";
		public override string HomeTitleSuffix => " Ivri H5680";
		public override string HomeFloatRightHebrew => "עִבְרִי";
		//<span class="hebrew">אָלֶף־בֵּית עִבְרִי</span>
	}

	private sealed class AlephTavsSE : LinkEnum
	{
		public AlephTavsSE() : base($"{nameof(Id.AlephTavs)}", Id.AlephTavs) { }
		public override string Index => "AlephTavs";
		public override string Title => "Aleph Tav's";
		public override string Icon => "fa-letter-aleph-tav";
		public override string ShortTitle => "";
		public override string HomeTitleSuffix => " Aleph Tav H853";
		public override string HomeFloatRightHebrew => "אֵת";
	}
	//<i class="fa text-danger fa-letter-aleph-tav fa-fw fa-3x" aria-hidden="true"></i>

	private sealed class BibleListSE : LinkEnum
	{
		public BibleListSE() : base($"{nameof(Id.BibleList)}", Id.BibleList) { }
		public override string Index => "List";
		public override string Title => "List";
		public override string Icon => "fas fa-torah";
		public override string ShortTitle => "";
		public override string HomeTitleSuffix => " Mispar H4557 ";
		public override string HomeFloatRightHebrew => "מִסְפָּר";
	}

	private sealed class TeachingSE : LinkEnum
	{
		public TeachingSE() : base($"{nameof(Id.Teaching)}", Id.Teaching) { }
		public override string Index => "Teaching";
		public override string Title => "Teaching";
		public override string Icon => "fas fa-graduation-cap";
		public override string ShortTitle => "";
		public override string HomeTitleSuffix => " Tamid H8548"; // Yara H3384; h2094 Zahar
		public override string HomeFloatRightHebrew => "לְלַמֵד";
	}

	private sealed class SitemapSE : LinkEnum
	{
		public SitemapSE() : base($"{nameof(Id.Sitemap)}", Id.Sitemap) { }
		public override string Index => "Sitemap";
		public override string Title => "Sitemap";
		public override string Icon => "fas fa-sitemap";
		public override string ShortTitle => "";
		public override string HomeTitleSuffix => " nahal H5095";
		public override string HomeFloatRightHebrew => "נָהַל";
	}

	//

	#endregion
}

/*
		public const string FaVerses = "fa fa-bookmark";
		public const string FaVerse = "fa fa-bookmark";
		public const string FaMultiVerseCsv = "fa fa-search-plus";
		public const string FaFavoriteVerses = "text-danger fa fa-star";
		public const string FaParasha = "fa fa-bookmark-o";
		public const string FaAlephTav = "text-danger ";
		public const string FaAbout = "fa fa-question";
		public const string FaContact = "fa fa-envelope-o";
		public const string FaTime = "fa fa-clock-o";

		public const string FaList = "fa fa-list";
		public const string FaBook = "fa fa-book";
		public const string FaArticle = "fa fa-newspaper-o";
		public const string FaHebrew = "fa fa-letter-aleph";
		public const string FaSegType = "fa fa-skype";
		public const string FaResource = "fa fa-globe";
		public const string FaVerseOffset = "fa fa-mars-double";  //fa-line-chart
		public const string FaSitemap = "fa fa-sitemap";
		public const string FaTeaching = "fa fa-graduation-cap";
https://myhebrewbiblecore.visualstudio.com/ConvertToCore/_versionControl?path=%24%2FConvertToCore%2FMyHebrewBible%2FMyHebrewBible.Web%2FPages%2FIcons.cs&vc.GitRepositoryName=%24%2FConvertToCore&_a=contents&version=T
 */