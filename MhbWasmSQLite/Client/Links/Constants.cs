namespace MhbWasmSQLite.Client.Links;

public static class About
{
	public const string Index = "/About";
	public const string Title = "About";
	public const string Icon = "fas fa-info";
}
/**/
public static class Account
{
	public const string Login = "/Account/Login";
	public const string Logout = "/Account/Logout";
	public const string LogoutAction = "Account/LogOut";
	public const string Profile = "/Account/Profile";

	public const string TitleAccessDenied = "Access Denied.";
	public const string TitleLogin = "Log in";
	public const string TitleLogout = "Log out";
	public const string TitleProfile = "Profile";

	public const string IconClaims = "fab fa-superpowers";
	public const string IconProfileVerified = "fas fa-check";
	public const string IconProfileNotVerified = "fas fa-question";
	public const string IconLogout = "fas fa-sign-out-alt";
	public const string IconLogin = "fas fa-sign-in-alt";
	public const string IconProfile = "fas fa-user";

	public static class PasswordChanged
	{
		public const string Index = "/account/PasswordChanged";
		public const string Title = " Password Changed Successfully";
		public const string PageTitle = " Password Changed";
		public const string Icon = "fas fa-key";
	}
}



public static class BibleSearch
{
	public const string Index = "/BibleSearch";
	public const string Title = "Bible Search";
	public const string Icon = "fas fa-search";  //fas fa-bible
}


public static class Counter
{
	public const string Index = "/counter";
	public const string Title = "Counter";
	public const string Icon = "fas fa-plus";
}

public static class Fetchdata
{
	public const string Index = "/fetchdata";
	public const string Title = "Fetch Data";
  public const string ShortTitle = "Weather Forecast";
  public const string Icon = "fas fa-list";
}

public static class Home
{
	public const string Index = "/";
	public const string Title = "My Hebrew Bible";
	public const string ShortTitle = "My Heb. Bib.";
	public const string Acronym = "M. H. B.";
	public const string PageTitle = "Home | MHB";
	public const string Icon = "fas fa-home";
	public const string Error = "/Error";
}

public static class NavigationSearch
{
	public const string Index = "/NavigationSearch";
	public const string Title = "Navigation Search";
	public const string Icon = "fas fa-compass"; //  fas fa-search
}


public static class Parasha
{
	public const string Index = "/Parasha";
	public const string Title = "Parasha";
	public const string Icon = "fas fa-torah";
	public const string IconCurrent = "far fa-bookmark";

	public const string IndexPrint = "/Parasha/IndexPrint";  // Deprecate
	public const string BackToButtonText = "Back to Parasha"; // Deprecate

	public static class MyHebrewBible
	{
		private const string baseUrl = "https://myhebrewbible.com/Parasha/Triennial/LivingMessiah/";
		public static string ParashaUrl(int id, string slug)
		{
			return $"{baseUrl}/{id}?slug={slug}/";
		}
	}
	public static class ListByBook
	{
		public const string Index = "/Parasha/ListByBook";
		public const string Title = "Current Parasha Table";
		public const string Icon = "fas fa-table";
	}

	public static class Archive
	{
		public const string Index = "/Parasha/Archive";
		public const string Title = "Parashot Archive";
		public const string Icon = "fas fa-archive";
	}

	public static class PrintTable
	{
		public const string Title = "Parasha Table (Print)";
		public const string Icon = "fas fa-print";
	}
}

public static class Sitemap
{
	public const string Index = "/Sitemap";
	public const string Title = "Sitemap";
	public const string Icon = "fas fa-sitemap";
}
