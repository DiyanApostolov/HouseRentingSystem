using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Agent;
using HouseRentingSystem.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class AgentController : Controller
    {
        private readonly IAgentService agentService;

        public AgentController(IAgentService _agentService)
        {
            agentService = _agentService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            if (await agentService.ExistById(User.Id()))
            {
                return BadRequest();
            }

            var model = new BecomeAgentModel();

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Become(BecomeAgentModel model  )
        {
            var userId = User.Id();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await agentService.UserWithPhoneNumberExist(model.PhoneNumber))
            {
                return BadRequest();
            }

            if (await agentService.ExistById(userId))
            {
                return BadRequest();
            }

            if (await agentService.UserHasRents(userId))
            {
                return BadRequest();
            }

            await agentService.Create(userId, model.PhoneNumber);

            return RedirectToAction("All", "House");
        }
    }
}
