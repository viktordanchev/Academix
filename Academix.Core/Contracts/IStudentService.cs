using Academix.Core.Models.Student;

namespace Academix.Core.Contracts
{
    public interface IStudentService
    {
        Task<StudentViewModel> GetStudentAsync(int studentId);
        Task<int> GetSchoolIdAsync(string teacherId);
    }
}
