using Academix.Core.Models.DirectorStudent;

namespace Academix.Core.Contracts
{
    public interface IDirectorStudentService
    {
        Task<IEnumerable<AllStudentsViewModel>> GetStudentsAsync(int schoolId);
        Task AddSubjectStudentAsync(int subjectId, int studentId);
        Task<bool> IsStudentFromSchoolAsync(int studentId, int schoolId);
        Task<bool> IsSubjectFromSchoolAsync(int subjectId, int schoolId);
        Task<bool> IsStudentHasSubjectAsync(int studentId, int subjectId);
        Task RemoveSubjectStudentAsync(int subjectId, int studentId);
        Task<string> GetStudentNameAsync(int studentId);
    }
}
