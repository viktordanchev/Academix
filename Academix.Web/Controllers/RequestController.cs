using Academix.Common.Constants;
using Academix.Core.Contracts;
using Academix.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Academix.Web.Controllers
{
    [Authorize(Roles = $"{RoleConstants.Admin.RoleName},{RoleConstants.Director.RoleName}")]
    public class RequestController : BaseController
    {
        private readonly AcademixDbContext _context;
        private readonly IRequestService _requestService;

        public RequestController(AcademixDbContext context, IRequestService requestService)
        {
            _context = context;
            _requestService = requestService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var requests = await _requestService.GetAllRequests(GetUserId());

            return View(requests);
        }

        [HttpGet]
        public async Task<IActionResult> Accept(int id)
        {
            var request = await _requestService.GetRequestById(id);

            if (request == null)
            {
                return RedirectToAction(nameof(All));
            }

            await _requestService.AssignToRole(request);
            await _requestService.RemoveRequest(request.Id);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Deny(int id)
        {
            var request = await _requestService.GetRequestById(id);

            if (request == null)
            {
                return RedirectToAction(nameof(All));
            }

            await _requestService.RemoveRequest(request.Id);

            return RedirectToAction(nameof(All));
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
