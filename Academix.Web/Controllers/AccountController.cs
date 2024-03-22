using Microsoft.AspNetCore.Mvc;

namespace Academix.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
