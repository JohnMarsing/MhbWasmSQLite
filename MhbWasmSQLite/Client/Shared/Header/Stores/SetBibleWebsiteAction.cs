using MhbWasmSQLite.Client.Shared.Header.Enums;

namespace MhbWasmSQLite.Client.Shared.Header.Stores;

public class SetBibleWebsiteAction
{
	/*	*/
	public BibleWebsite BibleWebsite { get; } 
	public SetBibleWebsiteAction() { }

	public SetBibleWebsiteAction(BibleWebsite BibleWebsite)
	{
		this.BibleWebsite = BibleWebsite;
	}

}
