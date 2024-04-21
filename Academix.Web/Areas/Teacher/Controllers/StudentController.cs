using Academix.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Academix.Web.Areas.Teacher.Controllers
{
    public class StudentController : TeacherBaseController
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string searchQuery = "")
        {
            var query = searchQuery.ToLower();

            var schoolId = await _studentService.GetSchoolIdAsync(GetUserId());
            var students = await _studentService.GetStudentsAsync(schoolId, GetUserId());

            if (!string.IsNullOrEmpty(query))
            {
                students = students
                    .Where(s => s.Name.ToLower().Contains(query)
                        || s.Class.ToLower().Contains(query));
            }

            return View(students);
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
