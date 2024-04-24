using Academix.Core.Contracts;
using Academix.Core.Models.DirectorStudent;
using Academix.Infrastructure.Data;
using Academix.Infrastructure.Data.Models;
using Academix.Infrastructure.Data.Models.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Academix.Core.Services
{
    public class DirectorStudentService : IDirectorStudentService
    {
        private readonly AcademixDbContext _context;

        public DirectorStudentService(AcademixDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AllStudentsViewModel>> GetStudentsAsync(int schoolId)
        {
            var students = await _context.Students
                .Where(s => s.Class.SchoolId == schoolId)
                .Select(s => new AllStudentsViewModel()
                {
                    Id = s.Id,
                    Name = $"{s.StudentIdentity.FirstName} {s.StudentIdentity.LastName}",
                    Address = s.Address != null ? s.Address : "None",
                    PhoneNumber = s.StudentIdentity.PhoneNumber != null ? s.StudentIdentity.PhoneNumber : "None",
                    TotalGrade = s.SubjectsStudent
                        .Where(ss => ss.StudentId == s.Id)
                        .Select(s => s.Subject.Grades.Average(g => g.GradeNumber))
                        .ToList()
                })
                .AsNoTracking()
                .ToListAsync();

            return students;
        }

        public async Task AddSubjectStudentAsync(int subjectId, int studentId)
        {
            var subjectStudent = new SubjectStudent()
            {
                SubjectId = subjectId,
                StudentId = studentId
            };

            await _context.SubjectsStudents.AddAsync(subjectStudent);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> IsStudentFromSchoolAsync(int studentId, int schoolId)
        {
            var student = await _context.Classes
                .FirstOrDefaultAsync(c => c.SchoolId == schoolId && c.Students.Any(s => s.Id == studentId));

            return student == null ? false : true;
        }

        public async Task<bool> IsSubjectFromSchoolAsync(int subjectId, int schoolId)
        {
            var subject = await _context.Subjects
                .FirstOrDefaultAsync(s => s.Id == subjectId && s.SchoolId == schoolId);

            return subject == null ? false : true;
        }

        public async Task<bool> IsStudentHasSubjectAsync(int studentId, int subjectId)
        {
            return await _context.SubjectsStudents
                .AnyAsync(ss => ss.SubjectId == subjectId && ss.StudentId == studentId);
        }

        public async Task RemoveSubjectStudentAsync(int subjectId, int studentId)
        {
            var subjectStudent = await _context.SubjectsStudents
                .FirstAsync(ss => ss.SubjectId == subjectId && ss.StudentId == studentId);

            _context.SubjectsStudents.Remove(subjectStudent);
            await _context.SaveChangesAsync();
        }

        public async Task<string> GetStudentNameAsync(int studentId)
        {
            var student = await _context.Students
                .Select(s => new
                {
                    s.Id,
                    s.StudentIdentity.FirstName,
                    s.StudentIdentity.LastName,
                })
                .FirstAsync (s => s.Id == studentId);

            return $"{student.FirstName}-{student.LastName}";
        }
    }
}
