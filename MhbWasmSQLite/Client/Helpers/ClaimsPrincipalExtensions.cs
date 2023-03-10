using System.Linq;
using System.Security.Claims;

// NOT IMPLEMENTED
//ToDo: remove this and use SecurityClaimsService (MhbWasmSQLite.Client.Services)
namespace MhbWasmSQLite.Client.Infrastructure;

public static class ClaimsPrincipalExtensions
{
	public static string? GetRoleLMM(this ClaimsPrincipal? user)
	{
		return user!.Claims!.FirstOrDefault(c => c.Type == "https://schemas.livingmessiah.com/roles")?.Value;
	}

	public static string? GetUserId(this ClaimsPrincipal user)
	{
		return user.Claims!.FirstOrDefault(c => c.Type == "sub")?.Value;
	}

	public static string? GetUserName(this ClaimsPrincipal user)
	{
		return user.Claims!.FirstOrDefault(c => c.Type == "name")?.Value;
	}

	public static string? GetUserNameSoapVersion(this ClaimsPrincipal user)
	{
		return user.Claims?.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Name)?.Value;
	}

	public static string? GetUserEmail(this ClaimsPrincipal user)
	{
		return user.Claims?.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Email)?.Value;
	}

	public static string? GetRoles(this ClaimsPrincipal user)
	{
		string roles = "";
		foreach (var claim in user.Claims)
		{
			if (claim.Type == Auth0.SchemaNameSpace)
			{
				roles += claim.Value;
			}
		}

		if (roles.Length > 0 && roles.IndexOf(',') > 0)
		{
			roles.Remove(roles.IndexOf(','));
		}

		return roles;
	}


	public static bool RoleHasAdmin(this ClaimsPrincipal user)
	{
		foreach (var claim in user.Claims)
		{
			if (claim.Type == Auth0.SchemaNameSpace && claim.Value == Roles.Admin)
			{
				return true;
			}
		}
		return false;
	}

	public static bool Verified(this ClaimsPrincipal user)
	{
		//return user.Claims?.FirstOrDefault(c => c.Type == "email_verified")?.Value;
		if (user.Claims != null)
		{
			var x = user.Claims?.FirstOrDefault(c => c.Type == "email_verified")?.Value;
			if (!string.IsNullOrEmpty(x))
			{
				bool b;
				bool.TryParse(x, out b);
				return b;
			}
			else
			{
				return false;
			}
		}
		else
		{
			return false;
		}
	}


}


// Gotten from C:\Users\JohnM\source\repos\LivingMessiahBlazor\MhbWasmSQLite.Client\Services\Auth0.cs
//using static MhbWasmSQLite.Client.Services.Auth0;
public static class Auth0
{
	public const string SchemeName = "Auth0";
	public const string CallbackPath = "/callback";
	public const string SchemaNameSpace = "https://schemas.livingmessiah.com/roles";
}

public static class Roles
{
	public const string Admin = "admin";
	public const string User = "user";
	public const string SuperUser = "superuser";

}