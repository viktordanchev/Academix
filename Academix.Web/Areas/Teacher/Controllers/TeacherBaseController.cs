using Academix.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academix.Web.Areas.Teacher.Controllers
{
    [Area(RoleConstants.Teacher.RoleName)]
    [Authorize(RoleConstants.Teacher.RoleName)]
    public class TeacherBaseController : Controller
    {
    }
}
