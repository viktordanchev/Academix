using Academix.Core.Contracts;
using Academix.Core.Models.Request;
using Academix.Infrastructure.Data;
using Academix.Infrastructure.Data.Models;
using Academix.Infrastructure.Data.Models.Mapping;
using Academix.Web.Extensions;
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
        private readonly AcademixDbContext _context;
        private readonly IRequestService _requestService;

        public RequestController(AcademixDbContext context, UserManager<ApplicationUser> userManager, IRequestService requestService)
        {
            _context = context;
            _userManager = userManager;
            _requestService = requestService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<AllViewModel> requests;

            if (User.IsAdmin())
            {
                requests = await _requestService.GetAllRequestsToAdmin(GetUserId());
            }
            else
            {
                requests = await _requestService.GetAllRequestsToDirector(GetUserId());
            }

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

                    school.Director = director;

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

                    var student2 = await _context.Students
                        .FirstAsync(s => s.Id == request.StudentId);

                    var studentParent = new StudentParent()
                    {
                        Student = student2,
                        Parent = parent
                    };

                    await _context.Parents.AddAsync(parent);
                    await _context.StudentsParents.AddAsync(studentParent);
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
