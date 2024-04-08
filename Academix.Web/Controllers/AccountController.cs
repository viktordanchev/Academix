using Academix.Infrastructure.Data;
using Academix.Infrastructure.Data.Models;
using Academix.Web.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> SignUp()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new SignUpViewModel();
            model.Roles = await GetRolesAsync();
            model.Schools = await GetSchoolsAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Roles = await GetRolesAsync();
                model.Schools = await GetSchoolsAsync();

                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                ModelState.AddModelError(string.Empty, "This email is already registered!");

                model.Roles = await GetRolesAsync();
                model.Schools = await GetSchoolsAsync();

                return View(model);
            }

            var school = await _context.Schools.FirstAsync(s => s.Id == model.SchoolId);

            if (school.DirectorId != 0 && model.Role == "Director")
            {
                ModelState.AddModelError(string.Empty, "This school has teacher already!");

                model.Roles = await GetRolesAsync();
                model.Schools = await GetSchoolsAsync();

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

                model.Roles = await GetRolesAsync();
                model.Schools = await GetSchoolsAsync();

                return View(model);
            }

            await _userManager.AddToRoleAsync(user, model.Role);

            switch (model.Role)
            {
                case "Teacher":
                    var teacher = new Teacher()
                    {
                        TeacherIdentity = user,
                        SchoolId = model.SchoolId
                    };

                    await _context.Teachers.AddAsync(teacher);
                    break;
                case "Student":
                    var student = new Student()
                    {
                        StudentIdentity = user,
                        ClassId = model.ClassId
                    };

                    await _context.Students.AddAsync(student);
                    break;
                case "Parent":
                    var parent = new Parent()
                    {
                        ParentIdentity = user
                    };

                    var parentStudent = await _context.Students
                        .FirstAsync(s => s.Id == model.StudentId);

                    parentStudent.Parent = parent;

                    await _context.Parents.AddAsync(parent);
                    break;
                case "Director":
                    var director = new Director()
                    {
                        DirectorIdentity = user
                    };

                    school.Director = director;

                    await _context.Directors.AddAsync(director);
                    break;
            }

            await _context.SaveChangesAsync();

            await _signInManager.SignInAsync(user, isPersistent: false);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
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

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
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
        private async Task<IEnumerable<string>> GetRolesAsync()
        {
            var roles = await _roleManager.Roles
                .Where(r => r.Name != "Administrator")
                .Select(r => r.Name)
                .AsNoTracking()
                .ToListAsync();

            return roles;
        }

        [HttpGet]
        private async Task<IEnumerable<InfoViewModel>> GetSchoolsAsync()
        {
            var schools = await _context.Schools
                .Select(s => new InfoViewModel()
                {
                    Id = s.Id,
                    Name = $"{s.Name} - {s.City.Name}"
                })
                .AsNoTracking()
                .ToListAsync();

            return schools;
        }
    }
}
