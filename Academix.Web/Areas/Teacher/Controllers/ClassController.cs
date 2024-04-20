using Microsoft.AspNetCore.Mvc;

namespace Academix.Web.Areas.Teacher.Controllers
{
    public class ClassController : TeacherBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
