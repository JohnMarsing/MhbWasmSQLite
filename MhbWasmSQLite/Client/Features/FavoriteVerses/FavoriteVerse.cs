using MhbWasmSQLite.Shared;
using System.Collections.Generic;

namespace MhbWasmSQLite.Client.Features.FavoriteVerses;

public class FavoriteVerse
{
	public string PartialView { get; set; }
	public string VerseName { get; set; }
	public string VerseNameAbrv { get; set; }  // Gen 1:1, or Exo 20:16-21
	public int ScriptureIdBeg { get; set; }
	public int ScriptureIdEnd { get; set; }
	public byte BookID { get; set; } // Used to put ScrollSpies into buckets
	public string VerseDescription { get; set; }
	public string Commentary { get; set; }
	public bool HasExtraInfo { get; set; }
	public bool ShowHebrew { get; set; }
	public List<ScriptureVM> ScriptureList { get; set; }

	public FavoriteVerse()
	{
		ShowHebrew = false;
	}

	public string ExtraInfoId
	{
		get
		{
			return ScriptureIdBeg.ToString() + "-" + ScriptureIdEnd.ToString() + "-extra-info";
		}
	}

}