using ClothesShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClothesShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            var model = new About
            {
                Title = "New clothes shop application",
                Description = "Buy very cheap and good outfits",
                Tags = new List<string>() { "hoodie","tshirt","pants"}
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
