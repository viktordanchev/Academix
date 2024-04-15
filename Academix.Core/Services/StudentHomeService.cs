using Academix.Core.Contracts;
using Academix.Core.Models.StudentHome;
using Academix.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Academix.Core.Services
{
    public class StudentHomeService : IStudentHomeService
    {
        private readonly AcademixDbContext _context;

        public StudentHomeService(AcademixDbContext context)
        {
            _context = context;
        }

        public async Task<int> GetStudent(string studentId)
        {
            var student = await _context.Students
                .FirstAsync(s => s.StudentIdentityId == studentId);

            return student.Id;
        }

        public async Task<IEnumerable<SubjectViewModel>> GetAllSubjects(int studentId)
        {
            var subjects = await _context.SubjectsStudents
                .Where(ss => ss.StudentId == studentId)
                .Select(ss => new SubjectViewModel()
                {
                    Name = ss.Subject.Name,
                    TeacherName = $"{ss.Subject.Teacher.TeacherIdentity.FirstName} {ss.Subject.Teacher.TeacherIdentity.LastName}",
                    AverageGrade = ss.Subject.Grades
                        .Average(g => g.GradeNumber),
                    Grades = ss.Subject.Grades
                        .Select(g => new GradeServiceModel()
                        {
                            GradeNumber = g.GradeNumber,
                            DateAndTime = g.DateAndTime,
                            GradeType = g.GradeType
                        })
                        .ToList(),
                    Absences = ss.Subject.Absences
                        .Select(a => new AbsenceServiceModel()
                        {
                            ExcusedAbsence = a.ExcusedAbsence,
                            DateAndTime = a.DateAndTime,
                            AbsenceType = a.AbsenceType
                        })
                        .ToList()
                })
                .AsNoTracking()
                .ToListAsync();

            return subjects;
        }
    }
}
