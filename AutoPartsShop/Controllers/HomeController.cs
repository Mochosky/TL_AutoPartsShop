
using AutoPartsShop.Interfaces;
using AutoPartsShop.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace AutoPartsShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPartRepository _partRepository;

        public HomeController(IPartRepository part)
        {
            _partRepository = part;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PartOnSale = _partRepository.GetPartsOnSale
            };
            return View(homeViewModel);
        }
    }
}
