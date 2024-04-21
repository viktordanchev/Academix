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
                    Id = s.StudentId,
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

        public async Task AddGradeAsync(int studentId, AddGradeViewModel model)
        {
            var grade = new Grade()
            {
                GradeNumber = model.GradeNumber,
                GradeType = model.GradeType,
                DateAndTime = DateTime.Now,
                SubjectId = model.SubjectId,
                StudentId = studentId
            };

            await _context.Grades.AddAsync(grade);
            await _context.SaveChangesAsync();
        }

        public async Task<int> GetSubjectIdAsync(string teacherId)
        {
            var subject = await _context.Subjects
                .FirstAsync(s => s.Teacher.TeacherIdentityId == teacherId);

            return subject.Id;
        }

        public async Task<IEnumerable<AllGradesViewModel>> GetGradesAsync(int studentId, int subjectId)
        {
             var grades = await _context.Grades
                .Where(g => g.SubjectId == subjectId && g.StudentId == studentId)
                .Select(g => new AllGradesViewModel()
                {
                    Id = g.Id,
                    GradeNumber = g.GradeNumber,
                    GradeType = g.GradeType,
                    DateAndTime = g.DateAndTime
                })
                .AsNoTracking()
                .ToListAsync();

            return grades;
        }

        public async Task RemoveGradeAsync(int gradeId)
        {
            var grade = await _context.Grades
                .FirstAsync(g => g.Id == gradeId);

            _context.Remove(grade);
            await _context.SaveChangesAsync();
        }
    }
}
