﻿using Academix.Infrastructure.Data;
using Academix.Infrastructure.Data.Models;
using Academix.Web.Models.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security.Claims;

namespace Academix.Web.Controllers
{
    public class AccountController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AcademixDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> singInManager, RoleManager<IdentityRole> roleManager, AcademixDbContext context)
        {
            _userManager = userManager;
            _signInManager = singInManager;
            _roleManager = roleManager;
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult SignUp()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new SignUpViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignUp(SignUpViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                ModelState.AddModelError(string.Empty, "This email is already registered!");

                return View(model);
            }

            user = new ApplicationUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(model);
            }

            await _signInManager.SignInAsync(user, isPersistent: false);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult SignIn()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignIn(SignInViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid email or password!");

                return View(model);
            }

            await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, lockoutOnFailure: false);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Manage()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddRole()
        {
            var model = new AddRoleViewModel();
            model.Roles = await GetAllRoles();
            model.Schools = await GetAllSchools();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(AddRoleViewModel model)
        {
            if (!await IsDataValid(model))
            {
                ModelState.AddModelError(string.Empty, "Invalid data.");

                model.Roles = await GetAllRoles();
                model.Schools = await GetAllSchools();

                return View(model);
            }

            var school = await _context.Schools
                .FirstAsync(s => s.Id == model.SchoolId);

            if (model.Role == "Director" && school.DirectorId != null)
            {
                ModelState.AddModelError(string.Empty, "This school has already director.");

                model.Roles = await GetAllRoles();
                model.Schools = await GetAllSchools();

                return View(model);
            }

            var request = new Request()
            {
                Role = model.Role,
                RequesterId = GetUserId(),
                SchoolId = model.SchoolId,
                ClassId = model.ClassId,
                StudentId = model.StudentId,
                Message = model.Message
            };

            if (model.Role == "Director")
            {
                var admins = await _context.Admins
                    .Select(u => u.Id)
                    .ToArrayAsync();

                request.AdminId = admins[0];
            }
            else
            {
                request.DirectorId = school.DirectorId;
            }

            await _context.Requests.AddAsync(request);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Authentication", "Home");
        }

        [HttpGet]
        public async Task<JsonResult> GetClassesBySchoolId(int schoolId)
        {
            var classes = await _context.Classes
                .Where(c => c.SchoolId == schoolId)
                .AsNoTracking()
                .ToListAsync();

            return Json(classes);
        }

        [HttpGet]
        public async Task<JsonResult> GetStudentsByClassId(int classId)
        {
            var students = await _context.Students
                .Where(s => s.ClassId == classId)
                .Select(s => new
                {
                    s.Id,
                    Name = $"{s.StudentIdentity.FirstName} {s.StudentIdentity.LastName}"
                })
                .AsNoTracking()
                .ToListAsync();

            return Json(students);
        }

        [HttpGet]
        private async Task<IEnumerable<string>> GetAllRoles()
        {
            var roles = await _roleManager.Roles
                .Where(r => r.Name != "Admin")
                .Select(r => r.Name)
                .AsNoTracking()
                .ToListAsync();

            return roles;
        }

        [HttpGet]
        private async Task<IEnumerable<InfoViewModel>> GetAllSchools()
        {
            var schools = await _context.Schools
                .Select(s => new InfoViewModel
                {
                    Id = s.Id,
                    Name = $"{s.Name} - {s.City.Name}"
                })
                .AsNoTracking()
                .ToListAsync();

            return schools;
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        private async Task<bool> IsDataValid(AddRoleViewModel model)
        {
            var result = true;

            var isRoleExist = await _roleManager.RoleExistsAsync(model.Role);

            var school = await _context.Schools
                .FirstOrDefaultAsync(s => s.Id == model.SchoolId);

            Student student = null;
            Class curClass = null;

            if(!isRoleExist || model.Role == "Admin" || school == null)
            {
                result = false;
            }
            else if (model.Role == "Student")
            {
                curClass = await _context.Classes
                .FirstOrDefaultAsync(c => c.Id == model.ClassId);

                if (curClass == null)
                {
                    result = false;
                }
            }
            else if (model.Role == "Parent")
            {
                curClass = await _context.Classes
                .FirstOrDefaultAsync(c => c.Id == model.ClassId);

                student = await _context.Students
                .FirstOrDefaultAsync(s => s.Id == model.StudentId);

                if (curClass == null || student == null)
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
