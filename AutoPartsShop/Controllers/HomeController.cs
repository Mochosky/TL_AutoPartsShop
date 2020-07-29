
using AutoPartsShop.Interfaces;
using AutoPartsShop.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace AutoPartsShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPart _part;
        public HomeController(IPart part)
        {
            _part = part;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PartOnSale = _part.GetPartsOnSale
            };
            return View(homeViewModel);
        }
    }
}
