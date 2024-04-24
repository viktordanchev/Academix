using Academix.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Academix.Web.Areas.Parent.Controllers
{
    public class StudentController : ParentBaseController
    {
        private readonly IParentStudentService _parentHomeService;

        public StudentController(IParentStudentService parentHomeService)
        {
            _parentHomeService = parentHomeService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var students = await _parentHomeService.GetStudentsInfoAsync(GetUserId());

            return View(students);
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
