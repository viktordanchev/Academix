using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academix.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
