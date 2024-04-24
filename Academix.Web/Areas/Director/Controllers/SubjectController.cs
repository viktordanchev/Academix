using Academix.Core.Contracts;
using Academix.Core.Models.Subject;
using Microsoft.AspNetCore.Mvc;

namespace Academix.Web.Areas.Director.Controllers
{
    public class SubjectController : DirectorBaseController
    {
        private readonly IDirectorSubjectService _subjectService;

        public SubjectController(IDirectorSubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpGet]
        public async Task<IActionResult> All(string student = "")
        {
            var schoolId = await _subjectService.GetSchoolIdAsync(GetUserId());
            var subjects = await _subjectService.GetSubjectsAsync(schoolId);

            if(string.IsNullOrEmpty(student))
            {
                TempData.Remove("StudentId");
            }

            return View(subjects);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var schoolId = await _subjectService.GetSchoolIdAsync(GetUserId());
            var teachers = await _subjectService.GetTeachersAsync(schoolId);

            var model = new AddSubjectViewModel();
            model.Teachers = teachers;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddSubjectViewModel model)
        {
            var schoolId = await _subjectService.GetSchoolIdAsync(GetUserId());

            if(!await IsModelValid(schoolId, model))
            {
                var teachers = await _subjectService.GetTeachersAsync(schoolId);
                model.Teachers = teachers;

                return View(model);
            }

            await _subjectService.AddSubjectAsync(schoolId, model);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            if(await _subjectService.IsSubjectExistAsync(id))
            {
                await _subjectService.RemoveSubjectAsync(id);
            }

            return RedirectToAction(nameof(All));
        }

        private async Task<bool> IsModelValid(int schoolId, AddSubjectViewModel model)
        {
            var isValid = true;

            if (await _subjectService.IsTeacherHasSubject(model.TeacherId))
            {
                ModelState.AddModelError(string.Empty, "This teacher has subject already");

                isValid = false;
            }

            if (!await _subjectService.IsTeacherExistInSchool(schoolId, model.TeacherId))
            {
                ModelState.AddModelError(string.Empty, "This teacher doesn't exist");

                isValid = false;
            }

            return isValid;
        }
    }
}
