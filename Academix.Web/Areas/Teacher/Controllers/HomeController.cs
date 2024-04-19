using Microsoft.AspNetCore.Mvc;

namespace Academix.Web.Areas.Teacher.Controllers
{
    public class HomeController : TeacherBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
