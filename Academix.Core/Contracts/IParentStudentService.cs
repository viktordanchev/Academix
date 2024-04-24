using Academix.Core.Models.Students;

namespace Academix.Core.Contracts
{
    public interface IParentStudentService
    {
        Task<IEnumerable<StudentViewModel>> GetStudentsInfoAsync(string parentId);
    }
}
