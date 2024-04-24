using Academix.Core.Models.Dashboard;

namespace Academix.Core.Contracts
{
    public interface IStudentDashboardService
    {
        Task<StudentServiceModel> GetStudentAsync(string studentId);
        Task<IEnumerable<SubjectServiceModel>> GetAllSubjectsAsync(int studentId);
    }
}
