using ClothesShop.Application.ClothesShop;
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
        public async Task<IActionResult> Index()
        {
            var clothesShops = await _clothesShopService.GetAll();
            return View(clothesShops);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ClothesShopDto clothesShop)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _clothesShopService.Create(clothesShop);
            return RedirectToAction(nameof(Index));
        }


    }
}
