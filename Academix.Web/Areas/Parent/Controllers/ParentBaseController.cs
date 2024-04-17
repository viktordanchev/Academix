using Academix.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academix.Web.Areas.Parent.Controllers
{
    [Area(RoleConstants.Parent.RoleName)]
    [Authorize(Roles = RoleConstants.Parent.RoleName)]
    public class ParentBaseController : Controller
    {
    }
}
