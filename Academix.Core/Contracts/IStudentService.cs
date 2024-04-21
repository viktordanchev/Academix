using Academix.Core.Models;
using Academix.Core.Models.Student;

namespace Academix.Core.Contracts
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentViewModel>> GetStudentsAsync(int schoolId, string teacherId);
        Task<int> GetSchoolIdAsync(string teacherId);
        public async Task AddGradeAsync(int studentId, int subjectId, GradeServiceModel model)
    }
}
