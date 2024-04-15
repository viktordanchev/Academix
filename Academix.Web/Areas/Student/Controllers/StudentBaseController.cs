using Academix.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academix.Web.Areas.Student.Controllers
{
    [Area(RoleConstants.Student.RoleName)]
    [Authorize(Roles = RoleConstants.Student.RoleName)]
    public class StudentBaseController : Controller
    {
    }
}
