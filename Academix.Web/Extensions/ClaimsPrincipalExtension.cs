using System.Security.Claims;
using static Academix.Common.Constants.RoleConstants;

namespace Academix.Web.Extensions
{
    public static class ClaimsPrincipalExtension
    {
        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(Administrator.RoleName);
        }

        public static bool IsDirector(this ClaimsPrincipal user)
        {
            return user.IsInRole(Director.RoleName);
        }
    }
}
