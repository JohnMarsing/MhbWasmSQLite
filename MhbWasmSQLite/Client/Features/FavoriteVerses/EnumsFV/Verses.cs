using Ardalis.SmartEnum;
using MhbWasmSQLite.Client.Features.FavoriteVerses.DetailContent;

namespace MhbWasmSQLite.Client.Features.FavoriteVerses.EnumsFV;

public abstract class Verses : SmartEnum<Verses>
{
	#region Id's
	private static class Id
	{
		internal const int Gen_1_1 = 1;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly Verses Gen_1_1 = new Gen_1_1SE();
	public static readonly Verses Gen_49_10 = new Gen_49_10SE();
	public static readonly Verses Psa_98_3 = new Psa_98_3SE();
	public static readonly Verses Psa_122_1_to_9 = new Psa_122_1_to_9SE();
	public static readonly Verses Isa_1_17_to_18 = new Isa_1_17_to_18SE();
	public static readonly Verses Isa_2_3_to_4 = new Isa_2_3_to_4SE();
	public static readonly Verses Isa_9_6 = new Isa_9_6SE();
	public static readonly Verses Isa_11_11_to_13 = new Isa_11_11_to_13SE();
	public static readonly Verses Isa_53_5_to_6 = new Isa_53_5_to_6SE();
	public static readonly Verses Jer_3_6_to_12 = new Jer_3_6_to_12SE();
	public static readonly Verses Exo_15_18 = new Exo_15_18SE();
	public static readonly Verses Jer_31_31_to_34 = new Jer_31_31_to_34SE();
	public static readonly Verses Exo_19_3_to_6 = new Exo_19_3_to_6SE();
	public static readonly Verses Exo_19_7_to_8 = new Exo_19_7_to_8SE();
	public static readonly Verses Exo_20_16_to_21 = new Exo_20_16_to_21SE();
	public static readonly Verses Exo_21_5_to_6 = new Exo_21_5_to_6SE();
	public static readonly Verses Eze_36_26_to_27 = new Eze_36_26_to_27SE();
	public static readonly Verses Eze_37_15_to_17 = new Eze_37_15_to_17SE();
	public static readonly Verses Eze_37_26 = new Eze_37_26SE();
	public static readonly Verses Hos_1_1_to_11 = new Hos_1_1_to_11SE();
	public static readonly Verses Hos_4_6 = new Hos_4_6SE();
	public static readonly Verses Mal_4_4_to_6 = new Mal_4_4_to_6SE();
	public static readonly Verses Mat_5_17_to_20 = new Mat_5_17_to_20SE();
	public static readonly Verses Mat_5_22_to_26 = new Mat_5_22_to_26SE();
	public static readonly Verses Mat_10_5_to_7 = new Mat_10_5_to_7SE();
	public static readonly Verses Mat_15_24 = new Mat_15_24SE();
	public static readonly Verses Mat_18_15_to_17 = new Mat_18_15_to_17SE();
	public static readonly Verses Mat_18_18_to_20 = new Mat_18_18_to_20SE();
	public static readonly Verses Mat_22_37_to_40 = new Mat_22_37_to_40SE();
	public static readonly Verses Exo_31_12_to_17 = new Exo_31_12_to_17SE();
	public static readonly Verses Joh_1_17 = new Joh_1_17SE();
	public static readonly Verses Joh_14_15 = new Joh_14_15SE();
	public static readonly Verses Rom_1_1 = new Rom_1_1SE();
	public static readonly Verses Co1_7_20_to_24 = new Co1_7_20_to_24SE();
	public static readonly Verses Gal_3_28_to_29 = new Gal_3_28_to_29SE();
	public static readonly Verses Eph_2_12_to_19 = new Eph_2_12_to_19SE();
	public static readonly Verses Col_2_14 = new Col_2_14SE();
	public static readonly Verses Ti1_1_4 = new Ti1_1_4SE();
	public static readonly Verses Ti2_2_15 = new Ti2_2_15SE();
	public static readonly Verses Gen_12_1_to_2 = new Gen_12_1_to_2SE();
	public static readonly Verses Jam_1_27 = new Jam_1_27SE();
	public static readonly Verses Pe1_2_9_to_10 = new Pe1_2_9_to_10SE();
	public static readonly Verses Rev_21_24_to_27 = new Rev_21_24_to_27SE();
	public static readonly Verses Lev_19_17_to_18 = new Lev_19_17_to_18SE();
	public static readonly Verses Lev_26_40_to_42 = new Lev_26_40_to_42SE();
	public static readonly Verses Gen_15_12_to_17 = new Gen_15_12_to_17SE();
	public static readonly Verses Num_13_31_to_32 = new Num_13_31_to_32SE();
	public static readonly Verses Deu_16_18_to_20 = new Deu_16_18_to_20SE();
	public static readonly Verses Deu_17_14_to_20 = new Deu_17_14_to_20SE();
	public static readonly Verses Deu_17_18_to_20 = new Deu_17_18_to_20SE();
	public static readonly Verses Deu_18_15_to_19 = new Deu_18_15_to_19SE();
	public static readonly Verses Deu_18_20 = new Deu_18_20SE();
	public static readonly Verses Deu_19_15 = new Deu_19_15SE();
	public static readonly Verses Deu_19_16_to_21 = new Deu_19_16_to_21SE();
	public static readonly Verses Deu_24_1_to_4 = new Deu_24_1_to_4SE();
	public static readonly Verses Gen_3_12_to_17 = new Gen_3_12_to_17SE();
	public static readonly Verses Gen_4_9_to_14 = new Gen_4_9_to_14SE();
	// SE=SmartEnum
	#endregion

	private Verses(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract int BegId { get; }
	public abstract int EndId { get; }
	public abstract int BookId { get; }
	public abstract string VerseName { get; }
	public abstract string VerseNameAbrv { get; }
	public abstract string VerseDescription { get; }
	public abstract string Commentary { get; }
	public abstract bool HasExtraInfo { get; }
	#endregion

	#region Private Instantiation
	private sealed class Gen_1_1SE : Verses
	{
		public Gen_1_1SE() : base("Gen_1_1", 1) { }
		public override int BegId => 1;
		public override int EndId => 1;
		public override int BookId => 1;
		public override string VerseName => "Genesis 1:1";
		public override string VerseNameAbrv => "Gen 1:1";
		public override string VerseDescription => "Creation";
		public override string Commentary => "Arguably the most important verse in scripture";
		public override bool HasExtraInfo => true;
	}
	private sealed class Gen_3_12_to_17SE : Verses
	{
		public Gen_3_12_to_17SE() : base("Gen_3_12_to_17", 68) { }
		public override int BegId => 68;
		public override int EndId => 73;
		public override int BookId => 1;
		public override string VerseName => "Genesis 3:12-17";
		public override string VerseNameAbrv => "Gen 3:12-17";
		public override string VerseDescription => "Adam projects his problems on the woman and God";
		public override string Commentary => "This is the proximate cause of why we Adamites have found ourselves in &quot;the Bizarro world&quot;.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Gen_4_9_to_14SE : Verses
	{
		public Gen_4_9_to_14SE() : base("Gen_4_9_to_14", 89) { }
		public override int BegId => 89;
		public override int EndId => 94;
		public override int BookId => 1;
		public override string VerseName => "Genesis 4:9-14";
		public override string VerseNameAbrv => "Gen 4:9-14";
		public override string VerseDescription => "Brother&quot;s Keeper";
		public override string Commentary => "Are you your brother&quot;s keeper";
		public override bool HasExtraInfo => false;
	}
	private sealed class Gen_12_1_to_2SE : Verses
	{
		public Gen_12_1_to_2SE() : base("Gen_12_1_to_2", 300) { }
		public override int BegId => 300;
		public override int EndId => 301;
		public override int BookId => 1;
		public override string VerseName => "Genesis 12:1-2";
		public override string VerseNameAbrv => "Gen 12:1-2";
		public override string VerseDescription => "God calls Abram";
		public override string Commentary => "A promise from God to Abram was made, was this conditional";
		public override bool HasExtraInfo => false;
	}
	private sealed class Gen_15_12_to_17SE : Verses
	{
		public Gen_15_12_to_17SE() : base("Gen_15_12_to_17", 373) { }
		public override int BegId => 373;
		public override int EndId => 378;
		public override int BookId => 1;
		public override string VerseName => "Genesis 15:12-17";
		public override string VerseNameAbrv => "Gen 15:12-17";
		public override string VerseDescription => "The estate for Abram is created";
		public override string Commentary => "These verses bring up interesting questions with regard to what makes up the necessary elements of a contract/covenant";
		public override bool HasExtraInfo => false;
	}
	private sealed class Gen_49_10SE : Verses
	{
		public Gen_49_10SE() : base("Gen_49_10", 1484) { }
		public override int BegId => 1484;
		public override int EndId => 1484;
		public override int BookId => 1;
		public override string VerseName => "Genesis 49:10";
		public override string VerseNameAbrv => "Gen 49:10";
		public override string VerseDescription => "Until Shiloh cometh, the sceptre, Judah, giver of law";
		public override string Commentary => "This has law written all over it, but what does it mean???";
		public override bool HasExtraInfo => false;
	}
	private sealed class Exo_15_18SE : Verses
	{
		public Exo_15_18SE() : base("Exo_15_18", 1939) { }
		public override int BegId => 1939;
		public override int EndId => 1939;
		public override int BookId => 2;
		public override string VerseName => "Exodus 15:18";
		public override string VerseNameAbrv => "Exo 15:18";
		public override string VerseDescription => "YHVH is the King of Israel";
		public override string Commentary => "These needs to be contrasted to what happened in 1<sup>st</sup> chapter 8, and latter on in the Declaration of Independence";
		public override bool HasExtraInfo => true;
	}
	private sealed class Exo_19_3_to_6SE : Verses
	{
		public Exo_19_3_to_6SE() : base("Exo_19_3_to_6", 2030) { }
		public override int BegId => 2030;
		public override int EndId => 2033;
		public override int BookId => 2;
		public override string VerseName => "Exodus 19:3-6";
		public override string VerseNameAbrv => "Exo 19:3-6";
		public override string VerseDescription => "The promise of YHVH, i.e. the Offer, is given to Israel";
		public override string Commentary => "If Israel obeys the covenant, they shall be a peculiar treasure, a kingdom of priests for the nations";
		public override bool HasExtraInfo => true;
	}
	private sealed class Exo_19_7_to_8SE : Verses
	{
		public Exo_19_7_to_8SE() : base("Exo_19_7_to_8", 2034) { }
		public override int BegId => 2034;
		public override int EndId => 2035;
		public override int BookId => 2;
		public override string VerseName => "Exodus 19:7-8";
		public override string VerseNameAbrv => "Exo 19:7-8";
		public override string VerseDescription => "Offer accepted by Israel";
		public override string Commentary => "By having an offer and an acceptance which the meetings of the minds gives us a contract/covenant";
		public override bool HasExtraInfo => true;
	}
	private sealed class Exo_20_16_to_21SE : Verses
	{
		public Exo_20_16_to_21SE() : base("Exo_20_16_to_21", 2068) { }
		public override int BegId => 2068;
		public override int EndId => 2073;
		public override int BookId => 2;
		public override string VerseName => "Exodus 20:16-21";
		public override string VerseNameAbrv => "Exo 20:16-21";
		public override string VerseDescription => "Not to bear false witness";
		public override string Commentary => "An excellent quote from <b>Martin Luther</b> &quot;...[to] not deceitfully belie, betray, slander, nor defame our neighbor, but defend him, speak well of him, and <b>put the best construction on everything</b>&quot;.  See <sup>Deu 19:15-21, Jam 4:11</sup>";
		public override bool HasExtraInfo => false;
	}
	private sealed class Exo_21_5_to_6SE : Verses
	{
		public Exo_21_5_to_6SE() : base("Exo_21_5_to_6", 2083) { }
		public override int BegId => 2083;
		public override int EndId => 2084;
		public override int BookId => 2;
		public override string VerseName => "Exodus 21:5-6";
		public override string VerseNameAbrv => "Exo 21:5-6";
		public override string VerseDescription => "For the servant whose ear is bored";
		public override string Commentary => "Is it required for the House of Israel to (at least symbolically) to become this type of servant";
		public override bool HasExtraInfo => false;
	}
	private sealed class Exo_31_12_to_17SE : Verses
	{
		public Exo_31_12_to_17SE() : base("Exo_31_12_to_17", 2433) { }
		public override int BegId => 2433;
		public override int EndId => 2438;
		public override int BookId => 2;
		public override string VerseName => "Exodus 31:12-17";
		public override string VerseNameAbrv => "Exo 31:12-17";
		public override string VerseDescription => "my Sabbaths ye shall keep";
		public override string Commentary => "A blunt requirement for keeping the sabbath. It is a sign between Adonai and the children of Israel for ever";
		public override bool HasExtraInfo => false;
	}
	private sealed class Lev_19_17_to_18SE : Verses
	{
		public Lev_19_17_to_18SE() : base("Lev_19_17_to_18", 3299) { }
		public override int BegId => 3299;
		public override int EndId => 3300;
		public override int BookId => 3;
		public override string VerseName => "Leviticus 19:17-18";
		public override string VerseNameAbrv => "Lev 19:17-18";
		public override string VerseDescription => "Love thy neighbour as thyself";
		public override string Commentary => "See <sup>Mat 22:37-40</sup> where Yeshua quotes this verse and ties it with the <i>shema</i>; see also the <b>royal law</b> <sup>Jam 2:8</sup>";
		public override bool HasExtraInfo => false;
	}
	private sealed class Lev_26_40_to_42SE : Verses
	{
		public Lev_26_40_to_42SE() : base("Lev_26_40_to_42", 3565) { }
		public override int BegId => 3565;
		public override int EndId => 3567;
		public override int BookId => 3;
		public override string VerseName => "Leviticus 26:40-42";
		public override string VerseNameAbrv => "Lev 26:40-42";
		public override string VerseDescription => "Confessing the iniquity of the Fathers";
		public override string Commentary => "A remedy in the Torah for re-contracting with YHVY; See the article Confessions_per_Lev_26_40_thru_42_The_Iniquity_of_the_Fathers.pdf (Article ID 215)";
		public override bool HasExtraInfo => false;
	}
	private sealed class Num_13_31_to_32SE : Verses
	{
		public Num_13_31_to_32SE() : base("Num_13_31_to_32", 4107) { }
		public override int BegId => 4107;
		public override int EndId => 4108;
		public override int BookId => 4;
		public override string VerseName => "Numbers 13:31-32";
		public override string VerseNameAbrv => "Num 13:31-32";
		public override string VerseDescription => "The spies give an evil report";
		public override string Commentary => "This evil report is a pattern for the bill of divorce which happens centuries latter with the House of Israel";
		public override bool HasExtraInfo => true;
	}
	private sealed class Deu_16_18_to_20SE : Verses
	{
		public Deu_16_18_to_20SE() : base("Deu_16_18_to_20", 5361) { }
		public override int BegId => 5361;
		public override int EndId => 5363;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 16:18-20";
		public override string VerseNameAbrv => "Deu 16:18-20";
		public override string VerseDescription => "Justice Justice";
		public override string Commentary => "Part of Due Process is to do justice justly";
		public override bool HasExtraInfo => false;
	}
	private sealed class Deu_17_14_to_20SE : Verses
	{
		public Deu_17_14_to_20SE() : base("Deu_17_14_to_20", 5379) { }
		public override int BegId => 5379;
		public override int EndId => 5385;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 17:14-20";
		public override string VerseNameAbrv => "Deu 17:14-20";
		public override string VerseDescription => "Prophecy for the 1<sup>st</sup> Samuel ch. 8 type of King";
		public override string Commentary => "&quot;...you say, &quot;I will set over me a king like all the nations that are  around me&quot;";
		public override bool HasExtraInfo => true;
	}
	private sealed class Deu_17_18_to_20SE : Verses
	{
		public Deu_17_18_to_20SE() : base("Deu_17_18_to_20", 5383) { }
		public override int BegId => 5383;
		public override int EndId => 5385;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 17:18-20";
		public override string VerseNameAbrv => "Deu 17:18-20";
		public override string VerseDescription => "The King (The Sovereign) shall write a copy of the Torah";
		public override string Commentary => "&quot;...<sup>18</sup> he shall write him a copy of this law&quot; (see also <sup>Jos 8:32</sup>)...<sup>20</sup> &quot;That his heart be not lifted up above his brethren...&quot;";
		public override bool HasExtraInfo => false;
	}
	private sealed class Deu_18_15_to_19SE : Verses
	{
		public Deu_18_15_to_19SE() : base("Deu_18_15_to_19", 5400) { }
		public override int BegId => 5400;
		public override int EndId => 5404;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 18:15-19";
		public override string VerseNameAbrv => "Deu 18:15-19";
		public override string VerseDescription => "THE Prophet sent who is like God and Moses";
		public override string Commentary => "Regardless of who <i><b>Ha</b>Navi</i> is, verses 15 and 18 could be interpreted as someone who is like God and like man";
		public override bool HasExtraInfo => false;
	}
	private sealed class Deu_18_20SE : Verses
	{
		public Deu_18_20SE() : base("Deu_18_20", 5405) { }
		public override int BegId => 5405;
		public override int EndId => 5405;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 18:20";
		public override string VerseNameAbrv => "Deu 18:20";
		public override string VerseDescription => "The false prophet";
		public override string Commentary => "The &quot;Greek Jesus&quot; as described by antinomian Christianity is a false prophet because he &quot;did a way with the law&quot;  see also <sup>Deu 13:1-11</sup>";
		public override bool HasExtraInfo => false;
	}
	private sealed class Deu_19_15SE : Verses
	{
		public Deu_19_15SE() : base("Deu_19_15", 5422) { }
		public override int BegId => 5422;
		public override int EndId => 5422;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 19:15";
		public override string VerseNameAbrv => "Deu 19:15";
		public override string VerseDescription => "Truth as defined by Scripture";
		public override string Commentary => "&quot;...at the mouth of two witnesses, or at the mouth of three witnesses, shall the matter be established.&quot;  See also <sup>Deu 17:6</sup>, <sup>Num 35:30</sup>, <sup>Mat 18:16</sup>, <sup>Joh 8:17</sup>, <sup>2Co 13:1</sup>, <sup>1Ti 5:19</sup>, <sup>Heb 10:28</sup>";
		public override bool HasExtraInfo => false;
	}
	private sealed class Deu_19_16_to_21SE : Verses
	{
		public Deu_19_16_to_21SE() : base("Deu_19_16_to_21", 5423) { }
		public override int BegId => 5423;
		public override int EndId => 5428;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 19:16-21";
		public override string VerseNameAbrv => "Deu 19:16-21";
		public override string VerseDescription => "false witness and eye for an eye, tooth for tooth";
		public override string Commentary => "Regarding truth, scriptures is far more interested in its application to conflict resolution and not about hypothetical and philosophical / theological dissertations (see SCOTUS decision in <b>Ashwander vs TVA</b>). The context of the definition of truth (Deu 19:15).  See Exo 20:16";
		public override bool HasExtraInfo => false;
	}
	private sealed class Deu_24_1_to_4SE : Verses
	{
		public Deu_24_1_to_4SE() : base("Deu_24_1_to_4", 5527) { }
		public override int BegId => 5527;
		public override int EndId => 5530;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 24:1-4";
		public override string VerseNameAbrv => "Deu 24:1-4";
		public override string VerseDescription => "Bill of Divorce";
		public override string Commentary => "Since this list is heavily geared towards <b>The House of Israel</b> and the fact that she was given a <b>Bill of Divorce</b>, it seemed prudent to include these relevant verses.  RSTNE: &quot;Only with the death of the husband can she remarry, which is why Yahshua died to release the bride back to the Father&quot;<sup>footnote 611<sup>";
		public override bool HasExtraInfo => false;
	}
	private sealed class Psa_98_3SE : Verses
	{
		public Psa_98_3SE() : base("Psa_98_3", 15494) { }
		public override int BegId => 15494;
		public override int EndId => 15494;
		public override int BookId => 19;
		public override string VerseName => "Psalms 98:3";
		public override string VerseNameAbrv => "Psa 98:3";
		public override string VerseDescription => "Powerful words jam packed in one verse";
		public override string Commentary => "<b>House of Israel</b> <i>scattered to the</i> ends of the earth, Standalone Aleph Tav <span class='at-red'>&#1488&#1461&#1514</span> next to <b>Salvation</b> from Elohim.  <br />Three verses down, Psa 98:6, it says to make a joyful noise to <span class='hebrew'>יהוה</span> <sup><b>Yehovah</b></sup>, <span class='hebrew'><span class='nrl'>הַ</span>מֶּלֶךְ</span> <sup><b>the King</b></sup>.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Psa_122_1_to_9SE : Verses
	{
		public Psa_122_1_to_9SE() : base("Psa_122_1_to_9", 16091) { }
		public override int BegId => 16091;
		public override int EndId => 16099;
		public override int BookId => 19;
		public override string VerseName => "Psalms 122:1-9";
		public override string VerseNameAbrv => "Psa 122:1-9";
		public override string VerseDescription => "More on the covenant of ";
		public override string Commentary => "See the article <u>Pray-for-the-peace-of-Jerusalem-Psa-122.pdf</u>";
		public override bool HasExtraInfo => false;
	}
	private sealed class Isa_1_17_to_18SE : Verses
	{
		public Isa_1_17_to_18SE() : base("Isa_1_17_to_18", 17672) { }
		public override int BegId => 17672;
		public override int EndId => 17673;
		public override int BookId => 23;
		public override string VerseName => "Isaiah 1:17-18";
		public override string VerseNameAbrv => "Isa 1:17-18";
		public override string VerseDescription => "YHVH is a reasonable Elohim";
		public override string Commentary => "To reason with Elohim is implies that an offer is being made by Elohim to Israel. The context of is pure religion see <sup>Isa 1:17</sup> and <sup>Jam 1:27</sup>";
		public override bool HasExtraInfo => false;
	}
	private sealed class Isa_2_3_to_4SE : Verses
	{
		public Isa_2_3_to_4SE() : base("Isa_2_3_to_4", 17689) { }
		public override int BegId => 17689;
		public override int EndId => 17690;
		public override int BookId => 23;
		public override string VerseName => "Isaiah 2:3-4";
		public override string VerseNameAbrv => "Isa 2:3-4";
		public override string VerseDescription => "Judgment of the Nations, swords beat into plowhsares";
		public override string Commentary => "See the article <u>Prince-of-Peace-Sar-Shalom.doc</u>";
		public override bool HasExtraInfo => false;
	}
	private sealed class Isa_9_6SE : Verses
	{
		public Isa_9_6SE() : base("Isa_9_6", 17836) { }
		public override int BegId => 17836;
		public override int EndId => 17836;
		public override int BookId => 23;
		public override string VerseName => "Isaiah 9:6";
		public override string VerseNameAbrv => "Isa 9:6";
		public override string VerseDescription => "Prince of Peace";
		public override string Commentary => "For there to be a Prince of Peace <i>Sar Shalom</i>, it seems there would have to be a Peace Covenant/Contract";
		public override bool HasExtraInfo => false;
	}
	private sealed class Isa_11_11_to_13SE : Verses
	{
		public Isa_11_11_to_13SE() : base("Isa_11_11_to_13", 17896) { }
		public override int BegId => 17896;
		public override int EndId => 17898;
		public override int BookId => 23;
		public override string VerseName => "Isaiah 11:11-13";
		public override string VerseNameAbrv => "Isa 11:11-13";
		public override string VerseDescription => "Ephraim and Judah bury the hatchet";
		public override string Commentary => "...&quot;Ephraim shall not envy Judah, and Judah shall not vex Ephraim&quot; <sup>Isa 11:13</sup>";
		public override bool HasExtraInfo => false;
	}
	private sealed class Isa_53_5_to_6SE : Verses
	{
		public Isa_53_5_to_6SE() : base("Isa_53_5_to_6", 18717) { }
		public override int BegId => 18717;
		public override int EndId => 18718;
		public override int BookId => 23;
		public override string VerseName => "Isaiah 53:5-6";
		public override string VerseNameAbrv => "Isa 53:5-6";
		public override string VerseDescription => "The suffering servant";
		public override string Commentary => "What can I say but Wow! You just have to read the whole chapter.  Also notice a very powerful Standalone <span class='text-danger'>Aleph Tav</span> in <sup>Isa 53:6</sup>.  There is all kinds of legal nuances going on in this chapter but I want to focus in on <sup>Isa 53:5</sup> where this servant&quot;s suffering results in <b>peace</b>.  Who is it that needs a covenant of Peace but <b>the Lost Sheep of the House of Israel</b> who was given a <b>Bill of Divorce</b>.";
	public override bool HasExtraInfo => false;
	}
	private sealed class Jer_3_6_to_12SE : Verses
	{
		public Jer_3_6_to_12SE() : base("Jer_3_6_to_12", 19009) { }
		public override int BegId => 19009;
		public override int EndId => 19015;
		public override int BookId => 24;
		public override string VerseName => "Jeremiah 3:6-12";
		public override string VerseNameAbrv => "Jer 3:6-12";
		public override string VerseDescription => "Bill of Divorce";
		public override string Commentary => "backsliding Israel committed adultery, put away, and given a bill of divorce";
		public override bool HasExtraInfo => true;
	}
	private sealed class Jer_31_31_to_34SE : Verses
	{
		public Jer_31_31_to_34SE() : base("Jer_31_31_to_34", 19723) { }
		public override int BegId => 19723;
		public override int EndId => 19726;
		public override int BookId => 24;
		public override string VerseName => "Jeremiah 31:31-34";
		public override string VerseNameAbrv => "Jer 31:31-34";
		public override string VerseDescription => "The renewed covenant is to both houses";
		public override string Commentary => "Another powerful two house set of verses";
		public override bool HasExtraInfo => true;
	}
	private sealed class Eze_36_26_to_27SE : Verses
	{
		public Eze_36_26_to_27SE() : base("Eze_36_26_to_27", 21386) { }
		public override int BegId => 21386;
		public override int EndId => 21387;
		public override int BookId => 26;
		public override string VerseName => "Ezekiel 36:26-27";
		public override string VerseNameAbrv => "Eze 36:26-27";
		public override string VerseDescription => "New Heart, New Spirit";
		public override string Commentary => "What an awesome spiritual upgrade!  By doing so, we will walk in his statutes and judgments.  See the standalone Aleph Tav in verse 37 between cause and my statutes ";
		public override bool HasExtraInfo => false;
	}
	private sealed class Eze_37_15_to_17SE : Verses
	{
		public Eze_37_15_to_17SE() : base("Eze_37_15_to_17", 21413) { }
		public override int BegId => 21413;
		public override int EndId => 21415;
		public override int BookId => 26;
		public override string VerseName => "Ezekiel 37:15-17";
		public override string VerseNameAbrv => "Eze 37:15-17";
		public override string VerseDescription => "The two sticks of Judah and Ephraim joined together in Elohim's hand";
		public override string Commentary => "Another powerful two house set of verses";
		public override bool HasExtraInfo => false;
	}
	private sealed class Eze_37_26SE : Verses
	{
		public Eze_37_26SE() : base("Eze_37_26", 21424) { }
		public override int BegId => 21424;
		public override int EndId => 21424;
		public override int BookId => 26;
		public override string VerseName => "Ezekiel 37:26";
		public override string VerseNameAbrv => "Eze 37:26";
		public override string VerseDescription => "The covenant of peace";
		public override string Commentary => "A covenant is a special form of contract, but a contract nonetheless therefore you need to view this from the perspective of law, see also <sup>Isa 11:13-14</sup>";
		public override bool HasExtraInfo => false;
	}
	private sealed class Hos_1_1_to_11SE : Verses
	{
		public Hos_1_1_to_11SE() : base("Hos_1_1_to_11", 22096) { }
		public override int BegId => 22096;
		public override int EndId => 22106;
		public override int BookId => 28;
		public override string VerseName => "Hosea 1:1-11";
		public override string VerseNameAbrv => "Hos 1:1-11";
		public override string VerseDescription => "The Bill of Divorce given to the House of Israel / &apos;Ephraim&apos;";
		public override string Commentary => "Adonai has had enough as Ephraim has refused to take to heart the warnings given to her so the Bill of Divorce is her judgment and sentence.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Hos_4_6SE : Verses
	{
		public Hos_4_6SE() : base("Hos_4_6", 22140) { }
		public override int BegId => 22140;
		public override int EndId => 22140;
		public override int BookId => 28;
		public override string VerseName => "Hosea 4:6";
		public override string VerseNameAbrv => "Hos 4:6";
		public override string VerseDescription => "&apos;My people are destroyed for lack of knowledge...&apos;";
		public override string Commentary => "An oft quoted verse but only the first part is quoted not the rest.  The context of Hosea in the first chapter which describes the House of Israel getting the Bill of Divorce";
		public override bool HasExtraInfo => true;
	}
	private sealed class Mal_4_4_to_6SE : Verses
	{
		public Mal_4_4_to_6SE() : base("Mal_4_4_to_6", 23143) { }
		public override int BegId => 23143;
		public override int EndId => 23145;
		public override int BookId => 39;
		public override string VerseName => "Malachi 4:4-6";
		public override string VerseNameAbrv => "Mal 4:4-6";
		public override string VerseDescription => "Shomer the Law of Moses, Elijah the prophet, hearts turned";
		public override string Commentary => "The 400 year gap of scripture from the Old Testament to the New.  As there is a Standalone Aleph Tav in the verse of the English Old Testament, there is also one in the last sentence";
		public override bool HasExtraInfo => false;
	}
	private sealed class Mat_5_17_to_20SE : Verses
	{
		public Mat_5_17_to_20SE() : base("Mat_5_17_to_20", 23252) { }
		public override int BegId => 23252;
		public override int EndId => 23255;
		public override int BookId => 40;
		public override string VerseName => "Matthew 5:17-20";
		public override string VerseNameAbrv => "Mat 5:17-20";
		public override string VerseDescription => "The Sermon on the Mount: The Law and the Prophets";
		public override string Commentary => "These verses are found in the heart of the sermon on the mount where <i>Yeshua</i> is teaching the <b>Torah</b> and is at the heart of what <b>MHB</b> is all about.";
		public override bool HasExtraInfo => true;
	}
	private sealed class Mat_5_22_to_26SE : Verses
	{
		public Mat_5_22_to_26SE() : base("Mat_5_22_to_26", 23257) { }
		public override int BegId => 23257;
		public override int EndId => 23261;
		public override int BookId => 40;
		public override string VerseName => "Matthew 5:22-26";
		public override string VerseNameAbrv => "Mat 5:22-26";
		public override string VerseDescription => "One who has ought with your breather can not draw near with their <i>korban</i> offering";
		public override string Commentary => "This is an advanced teaching";
		public override bool HasExtraInfo => true;
	}
	private sealed class Mat_10_5_to_7SE : Verses
	{
		public Mat_10_5_to_7SE() : base("Mat_10_5_to_7", 23423) { }
		public override int BegId => 23423;
		public override int EndId => 23425;
		public override int BookId => 40;
		public override string VerseName => "Matthew 10:5-7";
		public override string VerseNameAbrv => "Mat 10:5-7";
		public override string VerseDescription => "Yeshua commands the &apos;sent forth ones&apos; <sup>G649 <i>apostello</i></sup>) with a message";
		public override string Commentary => "This begs the question, who are <b>The Lost Sheep of the House of Israel</b>? ";
		public override bool HasExtraInfo => false;
	}
	private sealed class Mat_15_24SE : Verses
	{
		public Mat_15_24SE() : base("Mat_15_24", 23658) { }
		public override int BegId => 23658;
		public override int EndId => 23658;
		public override int BookId => 40;
		public override string VerseName => "Matthew 15:24";
		public override string VerseNameAbrv => "Mat 15:24";
		public override string VerseDescription => "The identity of who Yeshua was sent for is given";
		public override string Commentary => "...&apos;<span class='text-danger'>I am not sent but unto the <b>lost sheep of the house of Israel</b></span>&apos;.  Again, this begs the question, who are <b>The Lost Sheep of the House of Israel</b> and what is special about them?  More precisely what is special and unique about them from a legal status perspective?";
	public override bool HasExtraInfo => false;
	}
	private sealed class Mat_18_15_to_17SE : Verses
	{
		public Mat_18_15_to_17SE() : base("Mat_18_15_to_17", 23743) { }
		public override int BegId => 23743;
		public override int EndId => 23745;
		public override int BookId => 40;
		public override string VerseName => "Matthew 18:15-17";
		public override string VerseNameAbrv => "Mat 18:15-17";
		public override string VerseDescription => "The due process of in house conflict resolution";
		public override string Commentary => "Yeshua gives us the process for resolving conflicts who are a member of your congregation";
		public override bool HasExtraInfo => false;
	}
	private sealed class Mat_18_18_to_20SE : Verses
	{
		public Mat_18_18_to_20SE() : base("Mat_18_18_to_20", 23746) { }
		public override int BegId => 23746;
		public override int EndId => 23748;
		public override int BookId => 40;
		public override string VerseName => "Matthew 18:18-20";
		public override string VerseNameAbrv => "Mat 18:18-20";
		public override string VerseDescription => "Binding in heaven and earth";
		public override string Commentary => "This is a <b>&apos;400 level&apos;</b> advanced teaching describing &apos;vertical&apos; jurisdictions and authority.  It is about the dichotomy of the heavenly realm and the earthly realm, between private matters and public matters.  See <sup>Mat 16:19</sup>";
		public override bool HasExtraInfo => false;
	}
	private sealed class Mat_22_37_to_40SE : Verses
	{
		public Mat_22_37_to_40SE() : base("Mat_22_37_to_40", 23910) { }
		public override int BegId => 23910;
		public override int EndId => 23913;
		public override int BookId => 40;
		public override string VerseName => "Matthew 22:37-40";
		public override string VerseNameAbrv => "Mat 22:37-40";
		public override string VerseDescription => "The two great commandments given";
		public override string Commentary => "How do you love the Messiah <sup>Joh 14:14</sup>, but to keep his commandments.  Yeshua gives us the two <b>great</b> commandments <sup>Lev 19:17-18</sup> and <sup>Deu 6:4-5</sup> and then says <span class='text-danger'>On these two commandments hang <b>all</b> the <b>law</b> and the <b>prophets</b></span>.  The same verbiage used in <sup>Mat 5:17</sup>";
	public override bool HasExtraInfo => false;
	}
	private sealed class Joh_1_17SE : Verses
	{
		public Joh_1_17SE() : base("Joh_1_17", 26062) { }
		public override int BegId => 26062;
		public override int EndId => 26062;
		public override int BookId => 43;
		public override string VerseName => "John 1:17";
		public override string VerseNameAbrv => "Joh 1:17";
		public override string VerseDescription => "The law of Moses and the Grace of Yeshua?";
		public override string Commentary => "This <i>but</i> is <b>butting</b> in! The but is added, and if removed, as it should be, the Torah compliments the grace and truth of the Messiah, if left in then it casts these ideas to be opposites of each other.  Moshe-Leads-you-to-Meshiach-Num-10-13, article #786";
		public override bool HasExtraInfo => false;
	}
	private sealed class Joh_14_15SE : Verses
	{
		public Joh_14_15SE() : base("Joh_14_15", 26684) { }
		public override int BegId => 26684;
		public override int EndId => 26684;
		public override int BookId => 43;
		public override string VerseName => "John 14:15";
		public override string VerseNameAbrv => "Joh 14:15";
		public override string VerseDescription => "How to love Yeshua but to keep his commandments.";
		public override string Commentary => "So what are his commandments? ";
		public override bool HasExtraInfo => false;
	}
	private sealed class Rom_1_1SE : Verses
	{
		public Rom_1_1SE() : base("Rom_1_1", 27932) { }
		public override int BegId => 27932;
		public override int EndId => 27932;
		public override int BookId => 45;
		public override string VerseName => "Romans 1:1";
		public override string VerseNameAbrv => "Rom 1:1";
		public override string VerseDescription => "Legal Status of Paul: Bond Servant of Yeshua Messiah";
		public override string Commentary => "Romans 1:1-6 is Paul&quot;s calling card from which he is declaring is status.  If one were to ask Paul &quot;<i>Quo Warranto</i>&quot; (by what authority), could he not claim Exodus 21:5-6?";
		public override bool HasExtraInfo => false;
	}
	private sealed class Co1_7_20_to_24SE : Verses
	{
		public Co1_7_20_to_24SE() : base("Co1_7_20_to_24", 28508) { }
		public override int BegId => 28508;
		public override int EndId => 28512;
		public override int BookId => 46;
		public override string VerseName => "1 Corinthians 7:20-24";
		public override string VerseNameAbrv => "1Co 7:20-24";
		public override string VerseDescription => "Freeman, Paid for a Price";
		public override string Commentary => "Marsing&quot;s maxim: The perceived paradox to become free you have to become a bond servant; see <sup>1Co 6:20<sup>";
		public override bool HasExtraInfo => true;
	}
	private sealed class Gal_3_28_to_29SE : Verses
	{
		public Gal_3_28_to_29SE() : base("Gal_3_28_to_29", 29131) { }
		public override int BegId => 29131;
		public override int EndId => 29132;
		public override int BookId => 48;
		public override string VerseName => "Galatians 3:28-29";
		public override string VerseNameAbrv => "Gal 3:28-29";
		public override string VerseDescription => "Seed of Abraham, heirs according to the promise";
		public override string Commentary => "What does Paul mean when he says there is no distinction between Jew or Greek and how does this comport with Yeshua who said <span class='text-danger'>I am not sent but unto the <b>lost sheep of the house of Israel</b></span>&apos; <sup>Mat 15:24</sup> see also <sup>Mat 10:6</sup>";
	public override bool HasExtraInfo => false;
	}
	private sealed class Eph_2_12_to_19SE : Verses
	{
		public Eph_2_12_to_19SE() : base("Eph_2_12_to_19", 29242) { }
		public override int BegId => 29242;
		public override int EndId => 29249;
		public override int BookId => 49;
		public override string VerseName => "Ephesians 2:12-19";
		public override string VerseNameAbrv => "Eph 2:12-19";
		public override string VerseDescription => "Middle Wall of Partition Broken Down";
		public override string Commentary => "To much to comment on, see the Extra Page";
		public override bool HasExtraInfo => true;
	}
	private sealed class Col_2_14SE : Verses
	{
		public Col_2_14SE() : base("Col_2_14", 29509) { }
		public override int BegId => 29509;
		public override int EndId => 29509;
		public override int BookId => 51;
		public override string VerseName => "Colossians 2:14";
		public override string VerseNameAbrv => "Col 2:14";
		public override string VerseDescription => "Handwriting of ordinances nailing it to his cross";
		public override string Commentary => "To much to comment on, see the Extra Page";
		public override bool HasExtraInfo => true;
	}
	private sealed class Ti1_1_4SE : Verses
	{
		public Ti1_1_4SE() : base("Ti1_1_4", 29701) { }
		public override int BegId => 29701;
		public override int EndId => 29701;
		public override int BookId => 54;
		public override string VerseName => "1 Timothy 1:4";
		public override string VerseNameAbrv => "1Ti 1:4";
		public override string VerseDescription => "Word study of edifying";
		public override string Commentary => "This word is <i>oikonomia</i> (Strong&quot;s <sup>G3622</sup>) which is where we get the word <b>economy</b><br />For more, see Economy-of-God-G3622-oikonomia-G3623-oikonomos-dispensation-steward.doc and The-Economy-of-God.doc";
		public override bool HasExtraInfo => false;
	}
	private sealed class Ti2_2_15SE : Verses
	{
		public Ti2_2_15SE() : base("Ti2_2_15", 29843) { }
		public override int BegId => 29843;
		public override int EndId => 29843;
		public override int BookId => 55;
		public override string VerseName => "2 Timothy 2:15";
		public override string VerseNameAbrv => "2Ti 2:15";
		public override string VerseDescription => "Study to show thyself approved";
		public override string Commentary => "Two levels of study";
		public override bool HasExtraInfo => true;
	}
	private sealed class Jam_1_27SE : Verses
	{
		public Jam_1_27SE() : base("Jam_1_27", 30294) { }
		public override int BegId => 30294;
		public override int EndId => 30294;
		public override int BookId => 59;
		public override string VerseName => "James 1:27";
		public override string VerseNameAbrv => "Jam 1:27";
		public override string VerseDescription => "Pure religion";
		public override string Commentary => "The definition for <b>religion</b> as defined in scripture is found n this verse";
		public override bool HasExtraInfo => false;
	}
	private sealed class Pe1_2_9_to_10SE : Verses
	{
		public Pe1_2_9_to_10SE() : base("Pe1_2_9_to_10", 30409) { }
		public override int BegId => 30409;
		public override int EndId => 30410;
		public override int BookId => 60;
		public override string VerseName => "1 Peter 2:9-10";
		public override string VerseNameAbrv => "1Pe 2:9-10";
		public override string VerseDescription => "chosen generation, royal priesthood, holy nation (quote Hosea ch 1)";
		public override string Commentary => "Whose Peters audience but to none other than the Lost Sheep of the House of Israel who were <i>Lo Ami</i> Not my People and  <i>Lo Ruchmah</i> no mercy See Hos 1:6-10";
		public override bool HasExtraInfo => false;
	}
	private sealed class Rev_21_24_to_27SE : Verses
	{
		public Rev_21_24_to_27SE() : base("Rev_21_24_to_27", 31078) { }
		public override int BegId => 31078;
		public override int EndId => 31081;
		public override int BookId => 66;
		public override string VerseName => "Revelation 21:24-27";
		public override string VerseNameAbrv => "Rev 21:24-27";
		public override string VerseDescription => "Israel will judge the nations";
		public override string Commentary => "The tribes of Israel, a Kingdom of priests <sup>Exo 19:6</sup>, will adjudicate any matter that they receive from the Non-Israelite nations. What is the role of a priest but to be an intercessor between the people (the nations) and Elohim.";
		public override bool HasExtraInfo => false;
	}

	#endregion
}