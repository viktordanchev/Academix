using Academix.Core.Contracts;
using Academix.Core.Models.ParentHome;
using Academix.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Academix.Core.Services
{
    public class ParentHomeService : IParentHomeService
    {
        private readonly AcademixDbContext _context;

        public ParentHomeService(AcademixDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StudentViewModel>> GetStudentsInfo(string parentId)
        {
            var students = await _context.StudentsParents
                .Where(sp => sp.ParentId == parentId)
                .Select(s => new StudentViewModel()
                {
                    Name = $"{s.Student.StudentIdentity.FirstName} {s.Student.StudentIdentity.LastName}",
                    NumberInClass = s.Student.NumberInClass,
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
                                .Select(g => g.GradeNumber)
                                .ToList(),
                            Absences = ss.Subject.Absences.Count()
                        })
                        .ToList()
                })
                .AsNoTracking()
                .ToListAsync();

            return students;
        }
    }
}
