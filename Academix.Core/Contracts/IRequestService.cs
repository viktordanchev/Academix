﻿using Academix.Core.Models.Request;
using Academix.Infrastructure.Data.Models;

namespace Academix.Core.Contracts
{
    public interface IRequestService
    {
        Task<IEnumerable<AllViewModel>> GetAllRequests(string userId);
        Task<RequestServiceModel> GetRequestById(int requestId);
        Task AssignToRole(RequestServiceModel request);
        Task RemoveRequest(int requestId);
    }
}
