using Academix.Core.Models.Subject;

namespace Academix.Core.Contracts
{
    public interface ISubjectService
    {
        Task<int> GetSchoolIdAsync(string directorId);
        Task<IEnumerable<AllViewModel>> GetSubjectsAsync(int schoolId);
        Task<IEnumerable<AllTeachersViewModel>> GetTeachersAsync(int schoolId);
        Task AddSubjectAsync(int schoolId, AddSubjectViewModel model);
        Task<bool> IsTeacherHasSubject(int teacherId);
        Task<bool> IsTeacherExistInSchool(int schoolId, int teacherId);
        Task RemoveSubjectAsync(int subjectId);
        Task<bool> IsSubjectExistAsync(int subjectId);
    }
}
