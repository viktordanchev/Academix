using Academix.Core.Models.StudentHome;

namespace Academix.Core.Contracts
{
    public interface IStudentHomeService
    {
        Task<int> GetStudent(string studentId);
        Task<IEnumerable<SubjectViewModel>> GetAllSubjects(int studentId);
    }
}
