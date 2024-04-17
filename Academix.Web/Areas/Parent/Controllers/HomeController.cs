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
        private readonly AcademixDbContext _con;

        public HomeController(IParentHomeService parentHomeService, AcademixDbContext con)
        {
            _parentHomeService = parentHomeService;
            _con = con;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            return View();
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
