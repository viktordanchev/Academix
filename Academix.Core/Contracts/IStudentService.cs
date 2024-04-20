using Academix.Core.Models.Student;

namespace Academix.Core.Contracts
{
    public interface IStudentService
    {
        Task<IEnumerable<InfoViewModel>> GetClassesBySchoolAsync(int schoolId);
        Task<IEnumerable<InfoViewModel>> GetStudentsByClassAsync(int classId);
        Task<StudentViewModel> GetStudentAsync(int studentId);
        Task<int> GetSchoolIdAsync(string teacherId);
    }
}
