using Academix.Core.Contracts;
using Academix.Core.Models.Student;
using Academix.Infrastructure.Data.Models.Enumerations;
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
            var schoolId = await _studentService.GetSchoolIdAsync(GetUserId());
            var students = await _studentService.GetStudentsAsync(schoolId, GetUserId());

            if (!string.IsNullOrEmpty(searchQuery))
            {
                var query = searchQuery.ToLower();

                students = students
                    .Where(s => s.Name.ToLower().Contains(query)
                        || s.Class.ToLower().Contains(query));
            }

            return View(students);
        }

        [HttpGet]
        public IActionResult AddGrade()
        {
            var model = new AddGradeViewModel();
            var types = GetAllTypes();

            model.GradeTypes = types;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddGrade(int id, AddGradeViewModel model)
        {
            var subjectId = await _studentService.GetSubjectIdAsync(GetUserId());

            model.SubjectId = subjectId;
            await _studentService.AddGradeAsync(id, model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> AllGrades(int id)
        {
            var subjectId = await _studentService.GetSubjectIdAsync(GetUserId());

            var grades = await _studentService.GetGradesAsync(id, subjectId);

            return View(grades);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveGrade(int id)
        {
            await _studentService.RemoveGradeAsync(id);

            return RedirectToAction("AllGrades");
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        private IEnumerable<GradeTypeServiceModel> GetAllTypes()
        {
            var types = Enum
                .GetValues(typeof(GradeTypes))
                .Cast<GradeTypes>()
                .Select(gt => new GradeTypeServiceModel()
                {
                    Number = (int)gt,
                    Name = gt.ToString()
                })
                .ToList();

            return types;
        }
    }
}
