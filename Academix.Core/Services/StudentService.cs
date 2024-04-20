using Academix.Core.Contracts;
using Academix.Core.Models.Student;
using Academix.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Academix.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly AcademixDbContext _context;

        public StudentService(AcademixDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InfoViewModel>> GetClassesBySchoolAsync(int schoolId)
        {
            var classes = await _context.Classes
                .Where(c => c.SchoolId == schoolId)
                .Select(c => new InfoViewModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .AsNoTracking()
                .ToListAsync();

            return classes;
        }

        public async Task<IEnumerable<InfoViewModel>> GetStudentsByClassAsync(int classId)
        {
            var students = await _context.Students
                .Where(s => s.ClassId == classId)
                .Select(s => new InfoViewModel()
                {
                    Id = s.Id,
                    Name = $"{s.StudentIdentity.FirstName} {s.StudentIdentity.LastName}"
                })
                .AsNoTracking()
                .ToListAsync();

            return students;
        }

        public async Task<StudentViewModel> GetStudentAsync(int studentId)
        {
            var student = await _context.Students
                .Select(s => new StudentViewModel()
                {
                    Name = $"{s.StudentIdentity.FirstName} {s.StudentIdentity.LastName}",
                    ClassTeacher = $"{s.Class.ClassTeacher.TeacherIdentity.FirstName} {s.Class.ClassTeacher.TeacherIdentity.LastName}"
                })
                .FirstOrDefaultAsync(s => s.Id == studentId);

            return student;
        }

        public async Task<int> GetSchoolIdAsync(string teacherId)
        {
            var teacher = await _context.Teachers
                .FirstAsync(t => t.TeacherIdentityId == teacherId);

            return teacher.SchoolId;
        }
    }
}
