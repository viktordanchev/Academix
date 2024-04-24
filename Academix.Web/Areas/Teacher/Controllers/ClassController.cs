using Academix.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Academix.Web.Areas.Teacher.Controllers
{
    public class ClassController : TeacherBaseController
    {
        private readonly ITeacherClassService _classService;

        public ClassController(ITeacherClassService classService)
        {
            _classService = classService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var classId = await _classService.GetClassIdAsync(GetUserId());
            var students = await _classService.GetStudentsAsync(classId);

            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> AllAbsences(int id)
        {
            var absences = await _classService.GetAbsencesAsync(id);

            TempData["StudentId"] = id;

            return View(absences);
        }

        [HttpGet]
        public async Task<IActionResult> ExcuseAbsence(int id)
        {
            if (!await _classService.IsAbsenceExist(id))
            {
                return BadRequest();
            }

            await _classService.UpdatedAbsenceAsync(id);

            return RedirectToAction(nameof(AllAbsences), new { id = TempData["StudentId"] });
        }
    }
}
