using Academix.Core.Models.Request;

namespace Academix.Core.Contracts
{
    public interface IRequestService
    {
        Task<IEnumerable<AllViewModel>> GetAllRequestsAsync(string userId);
        Task<RequestServiceModel> GetRequestByIdAsync(int requestId);
        Task AssignToRoleAsync(RequestServiceModel request);
        Task RemoveRequestAsync(int requestId);
    }
}
