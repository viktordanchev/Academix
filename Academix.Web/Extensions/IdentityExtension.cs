using System.Security.Claims;
using System.Security.Principal;

namespace Academix.Web.Extensions
{
    public static class IdentityExtension
    {
        public static string GetFullName(this IIdentity identity)
        {
            if (identity == null)
                return null;

            var fullName = (identity as ClaimsIdentity).FirstOrNull("FullName");

            return fullName;
        }

        private static string FirstOrNull(this ClaimsIdentity identity, string claimType)
        {
            var val = identity.FindFirst(claimType);

            return val == null ? null : val.Value;
        }
    }
}
