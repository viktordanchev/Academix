using Academix.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Academix.Web.Areas.Director.Controllers
{
    [Area(RoleConstants.Director.RoleName)]
    [Authorize(Roles = RoleConstants.Director.RoleName)]
    public class DirectorBaseController : Controller
    {
        public string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
