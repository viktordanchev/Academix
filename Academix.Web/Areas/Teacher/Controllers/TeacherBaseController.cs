using Academix.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Academix.Web.Areas.Teacher.Controllers
{
    [Area(RoleConstants.Teacher.RoleName)]
    [Authorize(Roles = RoleConstants.Teacher.RoleName)]
    public class TeacherBaseController : Controller
    {
        public string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
