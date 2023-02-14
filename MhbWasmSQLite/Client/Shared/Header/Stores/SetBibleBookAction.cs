using MhbWasmSQLite.Client.Enums;

namespace MhbWasmSQLite.Client.Shared.Header.Stores;

public class SetBibleBookAction
{
	public BibleBook BibleBook { get; }
	public SetBibleBookAction() { }

	public SetBibleBookAction(BibleBook BibleBook)
	{
		this.BibleBook = BibleBook;
	}

}
