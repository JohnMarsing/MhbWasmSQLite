
namespace MhbWasmSQLite.Client.Shared.Header.LogSection;

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
