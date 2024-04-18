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

        public async Task<IEnumerable<StudentServiceModel>> GetStudentsInfo(int parentId)
        {
            var students = await _context.StudentsParents
                .Select(s => new StudentServiceModel()
                {
                    Name = $"{s.Student.StudentIdentity.FirstName} {s.Student.StudentIdentity.LastName}",
                    NumberInClass = s.Student.NumberInClass,
                    Class = s.Student.Class.Name,
                    ClassTeacher = $"{s.Student.Class.ClassTeacher.TeacherIdentity.FirstName} {s.Student.Class.ClassTeacher.TeacherIdentity.LastName}",
                    School = s.Student.Class.School.Name,
                    SchoolDirector = $"{s.Student.Class.School.Director.FirstName}{s.Student.Class.School.Director.LastName}",
                    Grades = s.Student.Grades
                    .Select(g => new GradeServiceModel()
                    {
                        GradeNumber = g.GradeNumber
                    })
                    .ToList(),
                    Absences = s.Student.Absences
                    .Select(a => new AbsenceServiceModel()
                    {
                        AbsenceType = a.AbsenceType
                    })
                    .ToList()
                })
                .AsNoTracking()
                .ToListAsync();

            return students;
        }
    }
}
