using Academix.Core.Contracts;
using Academix.Core.Models;
using Academix.Core.Models.Students;
using Academix.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Academix.Core.Services
{
    public class ParentStudentService : IParentStudentService
    {
        private readonly AcademixDbContext _context;

        public ParentStudentService(AcademixDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StudentViewModel>> GetStudentsInfoAsync(string parentId)
        {
            var students = await _context.StudentsParents
                .Where(sp => sp.ParentId == parentId)
                .Select(s => new StudentViewModel()
                {
                    Name = $"{s.Student.StudentIdentity.FirstName} {s.Student.StudentIdentity.LastName}",
                    Class = s.Student.Class.Name,
                    ClassTeacher = $"{s.Student.Class.ClassTeacher.TeacherIdentity.FirstName} {s.Student.Class.ClassTeacher.TeacherIdentity.LastName}",
                    School = s.Student.Class.School.Name,
                    SchoolDirector = $"{s.Student.Class.School.Director.FirstName} {s.Student.Class.School.Director.LastName}",
                    Subjects = s.Student.SubjectsStudent
                        .Where(ss => ss.StudentId == s.Student.Id)
                        .Select(ss => new SubjectServiceModel() 
                        { 
                            Name = ss.Subject.Name,
                            Grades = ss.Subject.Grades
                                .Where(g => g.StudentId == s.StudentId)
                                .Select(g => new GradeServiceModel()
                                {
                                    GradeNumber = g.GradeNumber,
                                    GradeType = g.GradeType,
                                    DateAndTime = g.DateAndTime,
                                })
                                .ToList(),
                            Absences = ss.Subject.Absences
                                .Where(a => a.StudentId == s.StudentId).Count()
                        })
                        .ToList()
                })
                .AsNoTracking()
                .ToListAsync();

            return students;
        }
    }
}
