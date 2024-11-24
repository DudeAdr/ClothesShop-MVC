using ClothesShop.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClothesShop.Controllers
{
    public class ClothesShopController : Controller
    {
        private IClothesShopService _clothesShopService;

        public ClothesShopController(IClothesShopService clothesShopService)
        {
            _clothesShopService = clothesShopService;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Domain.Entities.ClothesShop clothesShop)
        {
            await _clothesShopService.Create(clothesShop);
            return RedirectToAction(nameof(Create)); //TODO:REFACTOR
        }


    }
}
