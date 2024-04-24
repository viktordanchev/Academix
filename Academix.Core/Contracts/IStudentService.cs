using Academix.Core.Models.Student;

namespace Academix.Core.Contracts
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentViewModel>> GetStudentsAsync(int schoolId, string teacherId);
        Task<int> GetSchoolIdAsync(string teacherId);
        Task AddGradeAsync(int studentId, AddGradeViewModel model);
        Task<int> GetSubjectIdAsync(string teacherId);
        Task<IEnumerable<AllGradesViewModel>> GetGradesAsync(int studentId, int subjectId);
        Task RemoveGradeAsync(int gradeId);
        Task<IEnumerable<AllAbsencesViewModel>> GetAbsencesAsync(int studentId, int subjectId);
        Task AddAbsenceAsync(int studentId, int subjectId);
        Task RemoveAbsenceAsync(int absenceId);
        Task<bool> IsAbsenceItsForSubject(int absenceId, int subjectId);
        Task<bool> IsGradeItsForSubject(int gradeId, int subjectId);
    }
}
