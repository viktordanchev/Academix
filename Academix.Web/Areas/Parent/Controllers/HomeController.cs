using Academix.Core.Contracts;
using Academix.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Academix.Web.Areas.Parent.Controllers
{
    public class HomeController : ParentBaseController
    {
        private readonly IParentHomeService _parentHomeService;

        public HomeController(IParentHomeService parentHomeService)
        {
            _parentHomeService = parentHomeService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var students = await _parentHomeService.GetStudentsInfo(GetUserId());

            return View(students);
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
