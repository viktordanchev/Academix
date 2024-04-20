using Academix.Core.Models.Students;

namespace Academix.Core.Contracts
{
    public interface IStudentsService
    {
        Task<IEnumerable<StudentViewModel>> GetStudentsInfoAsync(string parentId);
    }
}
