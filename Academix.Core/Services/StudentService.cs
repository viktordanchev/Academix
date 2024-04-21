using Academix.Core.Contracts;
using Academix.Core.Models;
using Academix.Core.Models.Student;
using Academix.Infrastructure.Data;
using Academix.Infrastructure.Data.Models;
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

        public async Task<IEnumerable<StudentViewModel>> GetStudentsAsync(int schoolId, string teacherId)
        {
            var students = await _context.SubjectsStudents
                .Where(ss => ss.Student.Class.SchoolId == schoolId && ss.Subject.Teacher.TeacherIdentityId == teacherId)
                .Select(s => new StudentViewModel()
                {
                    Name = $"{s.Student.StudentIdentity.FirstName} {s.Student.StudentIdentity.LastName}",
                    Class = s.Student.Class.Name,
                    ClassTeacher = $"{s.Student.Class.ClassTeacher.TeacherIdentity.FirstName} {s.Student.Class.ClassTeacher.TeacherIdentity.LastName}",
                    Grades = s.Student.Grades
                        .Where(g => g.Subject.Teacher.TeacherIdentityId == teacherId)
                        .Select(g => new GradeServiceModel()
                        {
                            GradeNumber = g.GradeNumber,
                            GradeType = g.GradeType,
                            DateAndTime = g.DateAndTime
                        })
                        .ToList(),
                    Absences = s.Student.Absences
                        .Where(a => a.Subject.Teacher.TeacherIdentityId == teacherId)
                        .Select(a => new AbsenceServiceModel()
                        {
                            ExcusedAbsence = a.ExcusedAbsence,
                            DateAndTime = a.DateAndTime
                        })
                        .ToList()
                })
                .AsNoTracking()
                .ToListAsync();

            return students;
        }

        public async Task<int> GetSchoolIdAsync(string teacherId)
        {
            var teacher = await _context.Teachers
                .FirstAsync(t => t.TeacherIdentityId == teacherId);

            return teacher.SchoolId;
        }

        public async Task AddGradeAsync(int studentId, int subjectId, GradeServiceModel model)
        {
            var grade = new Grade()
            {
                GradeNumber = model.GradeNumber,
                GradeType = model.GradeType,
                DateAndTime = model.DateAndTime,
                SubjectId = subjectId,
                StudentId = studentId
            };

            await _context.Grades.AddAsync(grade);
            await _context.SaveChangesAsync();
        }
    }
}
