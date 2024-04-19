using Academix.Core.Models.ParentHome;

namespace Academix.Core.Contracts
{
    public interface IParentHomeService
    {
        Task<IEnumerable<StudentViewModel>> GetStudentsInfo(string parentId);
    }
}
