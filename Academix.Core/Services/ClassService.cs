using Academix.Core.Contracts;
using Academix.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Academix.Core.Services
{
    public class ClassService : IClassService
    {
        private readonly AcademixDbContext _context;

        public ClassService(AcademixDbContext context)
        {
            _context = context;
        }

        public async Task GetStudentsByClassIdAsync(int classId)
        {
            var students = await _context.Students
                .Where(s => s.ClassId == classId)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
