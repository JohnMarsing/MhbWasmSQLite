using Ardalis.SmartEnum;

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

    // SE=SmartEnum
    #endregion

    private Verses(string name, int value) : base(name, value) { } // Constructor

    #region Extra Fields
    public abstract int ScriptureIdBeg { get; }
    public abstract int ScriptureIdEnd { get; }
    public abstract string VerseName { get; }
    public abstract string VerseNameAbrv { get; }
    public abstract string VerseDescription { get; }
    public abstract string Commentary { get; }

    /*
	 PartialView = "Gen_1_1", 
	 public abstract int BookID = { get; }
	 HasExtraInfo = true
 */
    #endregion

    #region Private Instantiation

    private sealed class Gen_1_1SE : Verses
    {
        public Gen_1_1SE() : base($"{nameof(Id.Gen_1_1)}", Id.Gen_1_1) { }
        public override int ScriptureIdBeg => 1;
        public override int ScriptureIdEnd => 1;
        public override string VerseName => "Genesis 1:1";
        public override string VerseNameAbrv => "Gen 1:1";
        public override string VerseDescription => "Creation";
        public override string Commentary => "Arguably the most important verse in scripture";
    }

    #endregion
}