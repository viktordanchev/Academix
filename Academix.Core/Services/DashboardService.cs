using Academix.Core.Contracts;
using Academix.Core.Models;
using Academix.Core.Models.Dashboard;
using Academix.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Academix.Core.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly AcademixDbContext _context;

        public DashboardService(AcademixDbContext context)
        {
            _context = context;
        }

        public async Task<StudentServiceModel> GetStudentAsync(string studentId)
        {
            var student = await _context.Students
                .Where(s => s.StudentIdentityId == studentId)
                .Select(s => new StudentServiceModel()
                {
                    Id = s.Id,
                    School = s.Class.School.Name,
                    SchoolCity = s.Class.School.City.Name,
                    Class = s.Class.Name,
                    ClassTeacher = $"{s.Class.ClassTeacher.TeacherIdentity.FirstName} {s.Class.ClassTeacher.TeacherIdentity.LastName}"
                })
                .FirstAsync();

            return student;
        }

        public async Task<IEnumerable<SubjectServiceModel>> GetAllSubjectsAsync(int studentId)
        {
            var subjects = await _context.SubjectsStudents
                .Where(ss => ss.StudentId == studentId)
                .Select(ss => new SubjectServiceModel()
                {
                    Name = ss.Subject.Name,
                    TeacherName = $"{ss.Subject.Teacher.TeacherIdentity.FirstName} {ss.Subject.Teacher.TeacherIdentity.LastName}",
                    Grades = ss.Student.Grades
                        .Where(g => g.SubjectId == ss.SubjectId)
                        .Select(g => new GradeServiceModel()
                        {
                            GradeNumber = g.GradeNumber,
                            DateAndTime = g.DateAndTime,
                            GradeType = g.GradeType
                        })
                        .ToList(),
                    Absences = ss.Student.Absences
                        .Where(g => g.SubjectId == ss.SubjectId)
                        .Select(a => new AbsenceServiceModel()
                        {
                            IsExcused = a.ExcusedAbsence,
                            DateAndTime = a.DateAndTime
                        })
                        .ToList()
                })
                .AsNoTracking()
                .ToListAsync();

            return subjects;
        }
    }
}
