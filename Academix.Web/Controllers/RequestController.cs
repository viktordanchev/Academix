using Academix.Infrastructure.Data;
using Academix.Infrastructure.Data.Models;
using Academix.Web.Models.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Academix.Web.Controllers
{
    [Authorize(Roles = "Admin,Director")]
    public class RequestController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AcademixDbContext _context;

        public RequestController(AcademixDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var requests = await _context.Requests
                .Where(r => r.Director.DirectorIdentityId == GetUserId())
                .Select(r => new AllViewModel()
                {
                    Id = r.Id,
                    Role = r.Role,
                    RequesterName = $"{r.Requester.FirstName} + {r.Requester.LastName}",
                    Message = r.Message
                })
                .ToListAsync();

            return View(requests);
        }

        [HttpGet]
        public async Task<IActionResult> Accept(int id)
        {
            var request = await _context.Requests
                .Include(r => r.Requester)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (request == null)
            {
                return RedirectToAction(nameof(All));
            }

            await _userManager.AddToRoleAsync(request.Requester, request.Role);

            switch (request.Role)
            {
                case "Director":
                    var director = new Director()
                    {
                        DirectorIdentity = request.Requester
                    };

                    var school = await _context.Schools
                        .FirstAsync(s => s.Id == request.SchoolId);

                    await _context.Directors.AddAsync(director);
                    break;
                case "Student":
                    var student = new Student()
                    {
                        StudentIdentity = request.Requester,
                        ClassId = (int)request.ClassId
                    };

                    await _context.Students.AddAsync(student);
                    break;
                case "Teacher":
                    var teacher = new Teacher()
                    {
                        TeacherIdentity = request.Requester,
                        SchoolId = request.SchoolId
                    };

                    await _context.Teachers.AddAsync(teacher);
                    break;
                case "Parent":
                    var parent = new Parent()
                    {
                        ParentIdentity = request.Requester
                    };

                    var studentForParent = await _context.Students
                        .FirstAsync(s => s.ParentId == parent.Id);

                    studentForParent.ParentId = parent.Id;

                    await _context.Parents.AddAsync(parent);
                    break;
            }

            _context.Requests.Remove(request);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Deny(int id)
        {
            var request = await _context.Requests
                .Include(r => r.Requester)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (request == null)
            {
                return RedirectToAction(nameof(All));
            }

            _context.Requests.Remove(request);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
