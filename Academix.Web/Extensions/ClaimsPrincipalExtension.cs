using System.Security.Claims;
using static Academix.Common.Constants.RoleConstants;

namespace Academix.Web.Extensions
{
    public static class ClaimsPrincipalExtension
    {
        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(Admin.RoleName);
        }

        public static bool IsDirector(this ClaimsPrincipal user)
        {
            return user.IsInRole(Director.RoleName);
        }

        public static bool IsParent(this ClaimsPrincipal user)
        {
            return user.IsInRole(Parent.RoleName);
        }

        public static bool IsStudent(this ClaimsPrincipal user)
        {
            return user.IsInRole(Student.RoleName);
        }

        public static bool IsTeacher(this ClaimsPrincipal user)
        {
            return user.IsInRole(Teacher.RoleName);
        }
    }
}
