using Academix.Core.Contracts;
using Academix.Core.Models;
using Academix.Core.Models.Class;
using Academix.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Academix.Core.Services
{
    public class ClassService : IClassService
    {
        private readonly AcademixDbContext _context;

        public ClassService(AcademixDbContext context)
        {
            _context = context;
        }

        public async Task<int> GetClassIdAsync(string teacherId)
        {
            var currClass = await _context.Classes
                .FirstAsync(c => c.ClassTeacher.TeacherIdentity.Id == teacherId);

            return currClass.Id;
        }

        public async Task<IEnumerable<StudentViewModel>> GetStudentsAsync(int classId)
        {
            var students = await _context.Students
                .Where(s => s.ClassId == classId)
                .Select(s => new StudentViewModel()
                {
                    Id = s.Id,
                    Name = $"{s.StudentIdentity.FirstName} {s.StudentIdentity.LastName}",
                    Address = s.Address,
                    PhoneNumber = s.StudentIdentity.PhoneNumber,
                    Parents = s.StudentParents
                        .Where(sp => sp.StudentId == s.Id)
                        .Select(p => new ParentServiceModel()
                        {
                            Name = $"{p.Parent.FirstName} {p.Parent.LastName}",
                            PhoneNumber = p.Parent.PhoneNumber
                        })
                        .ToList(),
                    Absences = s.Absences
                        .Where(a => a.StudentId == s.Id)
                        .Select(a => new AbsenceServiceModel()
                        {
                            IsExcused = a.ExcusedAbsence,
                            DateAndTime = a.DateAndTime
                        })
                        .ToList()
                })
                .AsNoTracking()
                .ToListAsync();

            return students;
        }

        public async Task<IEnumerable<AbsenceViewModel>> GetAbsencesAsync(int studentId)
        {
            var absences = await _context.Absences
                .Where(a => a.StudentId == studentId)
                .Select(a => new AbsenceViewModel()
                {
                    AbsenceId = a.Id,
                    StudentId = a.StudentId,
                    Excused = a.ExcusedAbsence == true ? "Yes" : "No",
                    DateAndTime = a.DateAndTime
                })
                .AsNoTracking()
                .ToListAsync();

            return absences;
        }

        public async Task UpdatedAbsenceAsync(int id)
        {
            var absence = await _context.Absences
                .FirstAsync(a => a.Id == id);

            absence.ExcusedAbsence = true;
            await _context.SaveChangesAsync();
        }

        public async Task<bool> IsAbsenceExist(int id)
        {
            var absence = await _context.Absences
                .FirstOrDefaultAsync(a => a.Id == id);

            return absence == null ? false : true;
        }

        public async Task<bool> IsTeacherHasClass(string teacherId)
        {
            var currClass = await _context.Classes
                .FirstOrDefaultAsync(c => c.ClassTeacher.TeacherIdentity.Id == teacherId);

            return currClass == null ? false : true;
        }
    }
}
