using Academix.Core.Contracts;
using Academix.Core.Models.Dashboard;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Academix.Web.Areas.Student.Controllers
{
    public class DashboardController : StudentBaseController
    {
        private readonly IDashboardService _studentHomeService;

        public DashboardController(IDashboardService studentHomeService)
        {
            _studentHomeService = studentHomeService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var student = await _studentHomeService.GetStudentAsync(GetUserId());
            var subjects = await _studentHomeService.GetAllSubjectsAsync(student.Id);

            var info = new IndexViewModel()
            {
                Student = student,
                Subjects = subjects
            };

            return View(info);
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
