using Microsoft.AspNetCore.Mvc;

namespace Academix.Web.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
