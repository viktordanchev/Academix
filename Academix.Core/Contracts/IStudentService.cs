using Academix.Core.Models;
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
    }
}
