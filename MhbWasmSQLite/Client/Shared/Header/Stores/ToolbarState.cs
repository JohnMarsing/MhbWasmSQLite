using Fluxor;
using MhbWasmSQLite.Client.Enums;
using MhbWasmSQLite.Client.Shared.Header.Enums;

namespace MhbWasmSQLite.Client.Shared.Header.Stores;

/**/
[FeatureState]
public class ToolbarState
{
	public BibleBook BibleBook { get; }
	public BibleWebsite BibleWebsite { get; }
	public ToolbarState() { }

	public ToolbarState(BibleBook BibleBook, BibleWebsite BibleWebsite)
	{
		this.BibleBook = BibleBook;
		this.BibleWebsite = BibleWebsite;
	}
}

