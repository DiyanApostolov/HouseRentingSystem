using HouseRentingSystem.Core.Models.Agent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class AgentController : Controller
    {
        public IActionResult Become(BecomeAgentModel model  )
        {
            return RedirectToAction("All", "House");
        }
    }
}
