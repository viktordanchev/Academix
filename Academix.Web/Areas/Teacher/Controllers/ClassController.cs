﻿using Academix.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Academix.Web.Areas.Teacher.Controllers
{
    public class ClassController : TeacherBaseController
    {
        private readonly IClassService _classService;

        public ClassController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var classId = 0;

            if (await _classService.IsTeacherHasClass(GetUserId()))
            {
                classId = await _classService.GetClassIdAsync(GetUserId());
            }

            var students = await _classService.GetStudentsAsync(classId);

            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> AllAbsences(int id)
        {
            var absences = await _classService.GetAbsencesAsync(id);

            return View(absences);
        }

        [HttpGet]
        public async Task<IActionResult> ExcuseAbsence(int id, int studentId)
        {
            if (!await _classService.IsAbsenceExist(id))
            {
                return BadRequest();
            }

            await _classService.UpdatedAbsenceAsync(id);

            return RedirectToAction(nameof(AllAbsences), new { id = studentId });
        }
    }
}
