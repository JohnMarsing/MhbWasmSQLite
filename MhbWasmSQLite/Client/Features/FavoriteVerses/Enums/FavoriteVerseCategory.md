using Ardalis.SmartEnum;

// NOT BEING USED

namespace MhbWasmSQLite.Client.Features.FavoriteVerses.Enums;


public enum ScrollSpy
{
	Null = 0,
	Torah1 = 1,
	Torah2 = 2,
	Prophets = 3,
	NewTestament = 4
}


public abstract class FavoriteVerseCategory : SmartEnum<FavoriteVerseCategory>
{
	#region Id's
	// Use ScrollSpy
	#endregion

	private FavoriteVerseCategory(string name, int value) : base(name, value) { }  // Constructor

}

/*
{

	// See MyHebrewBible.Global\Components\Enums.txt for more design thoughts

	//ToDo: why not just call this FavoriteVerse? or maybe just Category
	public class FavoriteVerseCategory
	{
		public static List<FavoriteVerseCategory> All { get; } = new List<FavoriteVerseCategory>();

		public static FavoriteVerseCategory Torah1 { get; } = new FavoriteVerseCategory
		(ScrollSpy.Torah1, "Torah 1", 1, 2, ScrollSpy.Null, ScrollSpy.Torah2);

		public static FavoriteVerseCategory Torah2 { get; } = new FavoriteVerseCategory
		(ScrollSpy.Torah2, "Torah 2", 3, 5, ScrollSpy.Torah1, ScrollSpy.Prophets);

		public static FavoriteVerseCategory Prophets { get; } = new FavoriteVerseCategory
		(ScrollSpy.Prophets, "Prophets", 6, 39, ScrollSpy.Torah1, ScrollSpy.NewTestament);

		public static FavoriteVerseCategory NewTestament { get; } = new FavoriteVerseCategory
		(ScrollSpy.NewTestament, "New Testament", 40, 66, ScrollSpy.Prophets, ScrollSpy.Null);

		public ScrollSpy ScrollSpy { get; private set; }
		public string Name { get; private set; }
		public byte BookIdBeg { get; private set; }
		public byte BookIdEnd { get; private set; }
		public ScrollSpy Prev { get; private set; }
		public ScrollSpy Next { get; private set; }

		private FavoriteVerseCategory(ScrollSpy scrollSy, string name, byte begId, byte endId, ScrollSpy prev, ScrollSpy next)
		{
			ScrollSpy = scrollSy;
			Name = name;
			BookIdBeg = begId;
			BookIdEnd = endId;
			Prev = prev;
			Next = next;
			All.Add(this);
		}

		public static FavoriteVerseCategory FromEnum(ScrollSpy enumValue)
		{
			return All.SingleOrDefault(r => r.ScrollSpy == enumValue);  // Single
		}

		public static FavoriteVerseCategory FromString(string name)
		{
			return All.SingleOrDefault(r => String.Equals(r.ScrollSpy.ToString(), name, StringComparison.OrdinalIgnoreCase));
		}

		public static IEnumerable<FavoriteVerseCategory> ListOfEnhancedEnums()
		{
			// alternately, use a dictionary keyed by value
			return new[] { Torah1, Torah2, Prophets, NewTestament };
		}
	}
}


*/