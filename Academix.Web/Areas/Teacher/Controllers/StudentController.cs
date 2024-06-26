﻿using Academix.Core.Contracts;
using Academix.Core.Models.Student;
using Academix.Infrastructure.Data.Models.Enumerations;
using Microsoft.AspNetCore.Mvc;

namespace Academix.Web.Areas.Teacher.Controllers
{
    public class StudentController : TeacherBaseController
    {
        private readonly ITeacherStudentService _studentService;
        private readonly IDirectorStudentService _directorStudentService;

        public StudentController(ITeacherStudentService studentService, IDirectorStudentService directorStudentService)
        {
            _studentService = studentService;
            _directorStudentService = directorStudentService;
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

            if (!await _directorStudentService.IsStudentHasSubjectAsync(id, subjectId))
            {
                return BadRequest();
            }

            model.SubjectId = subjectId;
            await _studentService.AddGradeAsync(id, model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> AllGrades(int studentId)
        {
            var subjectId = await _studentService.GetSubjectIdAsync(GetUserId());

            if (!await _directorStudentService.IsStudentHasSubjectAsync(studentId, subjectId))
            {
                return BadRequest();
            }

            var grades = await _studentService.GetGradesAsync(studentId, subjectId);

            return View(grades);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveGrade(int id, int studentId)
        {
            var subjectId = await _studentService.GetSubjectIdAsync(GetUserId());

            if (!await _studentService.IsGradeItsForSubject(id, subjectId))
            {
                return BadRequest();
            }

            await _studentService.RemoveGradeAsync(id);

            return RedirectToAction("AllGrades", new { studentId });
        }

        [HttpGet]
        public async Task<IActionResult> AllAbsences(int studentId)
        {
            var subjectId = await _studentService.GetSubjectIdAsync(GetUserId());

            if (!await _directorStudentService.IsStudentHasSubjectAsync(studentId, subjectId))
            {
                return BadRequest();
            }

            var absences = await _studentService.GetAbsencesAsync(studentId, subjectId);

            return View(absences);
        }

        [HttpGet]
        public async Task<IActionResult> AddAbsence(int id)
        {
            var subjectId = await _studentService.GetSubjectIdAsync(GetUserId());

            if (!await _directorStudentService.IsStudentHasSubjectAsync(id, subjectId))
            {
                return BadRequest();
            }

            await _studentService.AddAbsenceAsync(id, subjectId);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> RemoveAbsence(int id, int studentId)
        {
            var subjectId = await _studentService.GetSubjectIdAsync(GetUserId());

            if (!await _studentService.IsAbsenceItsForSubject(id, subjectId))
            {
                return BadRequest();
            }

            await _studentService.RemoveAbsenceAsync(id);

            return RedirectToAction("AllAbsences", new { studentId });
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
