using Academix.Core.Contracts;
using Academix.Core.Models.Subject;
using Academix.Infrastructure.Data;
using Academix.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Academix.Core.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly AcademixDbContext _context;

        public SubjectService(AcademixDbContext context)
        {
            _context = context;
        }

        public async Task<int> GetSchoolIdAsync(string directorId)
        {
            var school = await _context.Schools
                .FirstAsync(t => t.DirectorId == directorId);

            return school.Id;
        }

        public async Task<IEnumerable<AllViewModel>> GetSubjectsAsync(int schoolId)
        {
            var subjects = await _context.Subjects
                .Where(s => s.SchoolId == schoolId)
                .Select(s => new AllViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    Teacher = $"{s.Teacher.TeacherIdentity.FirstName} {s.Teacher.TeacherIdentity.LastName}"
                })
                .AsNoTracking()
                .ToListAsync();

            return subjects;
        }

        public async Task<IEnumerable<AllTeachersViewModel>> GetTeachersAsync(int schoolId)
        {
            var teachers = await _context.Teachers
                .Where(t => t.SchoolId == schoolId)
                .Select(t => new AllTeachersViewModel()
                {
                    Id = t.Id,
                    Name = $"{t.TeacherIdentity.FirstName} {t.TeacherIdentity.LastName}"
                })
                .AsNoTracking()
                .ToListAsync();

            return teachers;
        }

        public async Task AddSubjectAsync(int schoolId, AddSubjectViewModel model)
        {
            var subject = new Subject()
            {
                Name = model.Name,
                SchoolId = schoolId,
                TeacherId = model.TeacherId
            };

            await _context.Subjects.AddAsync(subject);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> IsTeacherHasSubject(int teacherId)
        {
            var teacher = await _context.Subjects
                .FirstOrDefaultAsync(s => s.TeacherId == teacherId);

            return teacher == null ? false : true;
        }

        public async Task<bool> IsTeacherExistInSchool(int schoolId, int teacherId)
        {
            var teacher = await _context.Teachers
                .FirstOrDefaultAsync(t => t.Id == teacherId && t.SchoolId == schoolId);

            return teacher == null ? false : true;
        }

        public async Task RemoveSubjectAsync(int subjectId)
        {
            var subject = await _context.Subjects
                .FirstAsync(s => s.Id == subjectId);

            _context.Subjects.Remove(subject);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> IsSubjectExistAsync(int subjectId)
        {
            var subject = await _context.Subjects
               .FirstOrDefaultAsync(s => s.Id == subjectId);

            return subject == null ? false : true;
        }
    }
}
