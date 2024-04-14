using Academix.Core.Models.Request;

namespace Academix.Core.Contracts
{
    public interface IRequestService
    {
        Task<IEnumerable<AllViewModel>> GetAllRequestsToAdmin(string userId);
        Task<IEnumerable<AllViewModel>> GetAllRequestsToDirector(string userId);
    }
}
