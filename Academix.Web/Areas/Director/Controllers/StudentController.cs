using Academix.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Academix.Web.Areas.Director.Controllers
{
    public class StudentController : DirectorBaseController
    {
        private readonly IDirectorStudentService _directorStudentService;
        private readonly IDirectorSubjectService _subjectService;

        public StudentController(IDirectorStudentService directorStudentService, IDirectorSubjectService subjectService)
        {
            _directorStudentService = directorStudentService;
            _subjectService = subjectService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var schoolId = await _subjectService.GetSchoolIdAsync(GetUserId());
            var students = await _directorStudentService.GetStudentsAsync(schoolId);

            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> SelectSubject(int id)
        {
            var schoolId = await _subjectService.GetSchoolIdAsync(GetUserId());

            if (!await _directorStudentService.IsStudentFromSchoolAsync(id, schoolId))
            {
                return BadRequest();
            }

            var studentName = await _directorStudentService.GetStudentNameAsync(id);

            TempData["StudentId"] = id;

            return RedirectToAction("All", "Subject", new { student = studentName });
        }

        [HttpGet]
        public async Task<IActionResult> AddSubject(int id, int studentId)
        {
            var schoolId = await _subjectService.GetSchoolIdAsync(GetUserId());

            if (!await _directorStudentService.IsStudentFromSchoolAsync(studentId, schoolId)
                || !await _directorStudentService.IsSubjectFromSchoolAsync(id, schoolId))
            {
                return BadRequest();
            }

            var studentName = await _directorStudentService.GetStudentNameAsync(studentId);

            await _directorStudentService.AddSubjectStudentAsync(id, studentId);

            return RedirectToAction("All", "Subject", new { student = studentName });
        }

        [HttpGet]
        public async Task<IActionResult> RemoveSubject(int id, int studentId)
        {
            var schoolId = await _subjectService.GetSchoolIdAsync(GetUserId());

            if (!await _directorStudentService.IsStudentFromSchoolAsync(studentId, schoolId)
                || !await _directorStudentService.IsSubjectFromSchoolAsync(id, schoolId))
            {
                return BadRequest();
            }

            var studentName = await _directorStudentService.GetStudentNameAsync(studentId);

            await _directorStudentService.RemoveSubjectStudentAsync(id, studentId);

            return RedirectToAction("All", "Subject", new { student = studentName });
        }
    }
}
