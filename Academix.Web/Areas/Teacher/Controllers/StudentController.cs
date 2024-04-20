using Academix.Core.Contracts;
using Academix.Core.Models.Student;
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
        public async Task<IActionResult> Index()
        {
            var model = new StudentViewModel();
            var schoolId = await _studentService.GetSchoolIdAsync(GetUserId());

            model.SchoolId = schoolId;

            return View(model);
        }

        [HttpGet]
        public async Task<JsonResult> GetClassesBySchool(int schoolId)
        {
            var classes = await _studentService.GetClassesBySchoolAsync(schoolId);

            return Json(classes);
        }

        [HttpGet]
        public async Task<JsonResult> GetStudentsByClass(int classId)
        {
            var students = await _studentService.GetStudentsByClassAsync(classId);

            return Json(students);
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
