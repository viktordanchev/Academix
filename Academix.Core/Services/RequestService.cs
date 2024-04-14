using Academix.Core.Contracts;
using Academix.Core.Models.Request;
using Academix.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Academix.Core.Services
{
    public class RequestService : IRequestService
    {
        private readonly AcademixDbContext _context;

        public RequestService(AcademixDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AllViewModel>> GetAllRequestsToAdmin(string userId)
        {
            var requests = await _context.Requests
                   .Where(r => r.Admin.AdminIdentityId == userId)
                   .Select(r => new AllViewModel()
                   {
                       Id = r.Id,
                       Role = r.Role,
                       RequesterName = $"{r.Requester.FirstName} + {r.Requester.LastName}",
                       Message = r.Message
                   })
                   .AsNoTracking()
                   .ToListAsync();

            return requests;
        }

        public async Task<IEnumerable<AllViewModel>> GetAllRequestsToDirector(string userId)
        {
            var requests = await _context.Requests
                   .Where(r => r.Director.DirectorIdentityId == userId)
                   .Select(r => new AllViewModel()
                   {
                       Id = r.Id,
                       Role = r.Role,
                       RequesterName = $"{r.Requester.FirstName} + {r.Requester.LastName}",
                       Message = r.Message
                   })
                   .AsNoTracking()
                   .ToListAsync();

            return requests;
        }
    }
}
