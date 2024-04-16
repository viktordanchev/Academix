using Academix.Core.Models.StudentHome;

namespace Academix.Core.Contracts
{
    public interface IStudentHomeService
    {
        Task<StudentServiceModel> GetStudent(string studentId);
        Task<IEnumerable<SubjectServiceModel>> GetAllSubjects(int studentId);
    }
}
