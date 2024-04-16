using Academix.Core.Contracts;
using Academix.Core.Models.StudentHome;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Academix.Web.Areas.Student.Controllers
{
    public class HomeController : StudentBaseController
    {
        private readonly IStudentHomeService _studentHomeService;

        public HomeController(IStudentHomeService studentHomeService)
        {
            _studentHomeService = studentHomeService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var student = await _studentHomeService.GetStudent(GetUserId());
            var subjects = await _studentHomeService.GetAllSubjects(student.Id);

            var dashboard = new DashboardViewModel()
            {
                Student = student,
                Subjects = subjects
            };

            return View(dashboard);
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
