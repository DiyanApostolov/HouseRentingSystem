using HouseRentingSystem.Core.Models.House;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class HouseController : Controller
    {
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = new HousesQueryModel();

            return View(model);
        }

        public async Task<IActionResult> Mine()
        {
            var model = new HousesQueryModel();

            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var model = new HouseDetailsModel();

            return View(model);
        }

        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add (HouseFormModel model)
        {
            int id = 1;

            return RedirectToAction(nameof(Details), new { id });
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = new HouseFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, HouseFormModel model)
        {

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var model = new HouseFormModel();

            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> Rent(int id)
        {
            var model = new HouseFormModel();

            return RedirectToAction(nameof(Mine));
        }

        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {
            var model = new HouseFormModel();

            return RedirectToAction(nameof(Mine));
        }
    }
}
