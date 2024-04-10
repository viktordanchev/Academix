using Academix.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academix.Web.Areas.Director.Controllers
{
    [Area(RoleConstants.Director.RoleName)]
    [Authorize(Roles = RoleConstants.Director.RoleName)]
    public class DirectorBaseController : Controller
    {
    }
}
