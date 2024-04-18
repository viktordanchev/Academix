using Academix.Core.Contracts;
using Academix.Core.Models.Request;
using Academix.Infrastructure.Data;
using Academix.Infrastructure.Data.Models;
using Academix.Infrastructure.Data.Models.Mapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Academix.Core.Services
{
    public class RequestService : IRequestService
    {
        private readonly AcademixDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public RequestService(AcademixDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IEnumerable<AllViewModel>> GetAllRequests(string userId)
        {
            var requests = await _context.RequestsReceivers
                   .Where(r => r.ReceiverId == userId)
                   .Select(r => new AllViewModel()
                   {
                       Id = r.Request.Id,
                       Role = r.Request.Role,
                       RequesterName = $"{r.Request.Requester.FirstName} + {r.Request.Requester.LastName}",
                       Message = r.Request.Message
                   })
                   .AsNoTracking()
                   .ToListAsync();

            return requests;
        }

        public async Task<RequestServiceModel> GetRequestById(int requestId)
        {
            var request = await _context.Requests
                .Select(r => new RequestServiceModel()
                {
                    Id = r.Id,
                    Role = r.Role,
                    RequesterId = r.RequesterId,
                    SchoolId = r.SchoolId,
                    ClassId = r.ClassId,
                    StudentId = r.StudentId,
                    Message = r.Message
                })
                .FirstOrDefaultAsync(r => r.Id == requestId);

            return request;
        }

        public async Task AssignToRole(RequestServiceModel request)
        {
            var requester = await _userManager.FindByIdAsync(request.RequesterId);

            await _userManager.AddToRoleAsync(requester, request.Role);

            switch (request.Role)
            {
                case "Director":
                    var school = await _context.Schools
                        .FirstAsync(s => s.Id == request.SchoolId);

                    school.Director = requester;
                    break;
                case "Student":
                    var student = new Student()
                    {
                        StudentIdentity = requester,
                        ClassId = (int)request.ClassId
                    };

                    await _context.Students.AddAsync(student);
                    break;
                case "Teacher":
                    var teacher = new Teacher()
                    {
                        TeacherIdentity = requester,
                        SchoolId = request.SchoolId
                    };

                    await _context.Teachers.AddAsync(teacher);
                    break;
                case "Parent":
                    var student2 = await _context.Students
                        .FirstAsync(s => s.Id == request.StudentId);

                    var studentParent = new StudentParent()
                    {
                        Student = student2,
                        Parent = requester
                    };

                    await _context.StudentsParents.AddAsync(studentParent);
                    break;
            }

            await _context.SaveChangesAsync();
        }

        public async Task RemoveRequest(int requestId)
        {
            var request = await _context.Requests
                .FirstAsync(r => r.Id == requestId);

            _context.Requests.Remove(request);
            await _context.SaveChangesAsync();
        }
    }
}
