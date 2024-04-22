using Academix.Core.Models.Class;

namespace Academix.Core.Contracts
{
    public interface IClassService
    {
        Task<int> GetClassIdAsync(string teacherId);
        Task<IEnumerable<StudentViewModel>> GetStudentsAsync(int classId);
        Task<IEnumerable<AbsenceViewModel>> GetAbsencesAsync(int studentId);
        Task UpdatedAbsenceAsync(int id);
        Task<bool> IsAbsenceExist(int id);
    }
}
