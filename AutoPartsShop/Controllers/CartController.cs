using System.Linq;

using AutoPartsShop.Interfaces;
using AutoPartsShop.Models;
using AutoPartsShop.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace AutoPartsShop.Controllers
{
    public class CartController : Controller
    {
        private readonly IPartRepository _partRepository;
        private readonly Cart _cart;

        public CartController(IPartRepository part, Cart cart)
        {
            _partRepository = part;
            _cart = cart;
        }

        public ViewResult Index()
        {
            _cart.CartItems = _cart.GetCartItems();

            var cartViewModel = new CartViewModel
            {
                Cart = _cart,
                CartPrice = _cart.GetCartPrice()
            };

            return View(cartViewModel);
        }

        public RedirectToActionResult AddToCart(int partId)
        {
            var selectedPart = _partRepository.GetAllParts.FirstOrDefault(p => p.PartId == partId);

            if (selectedPart != null)
            {
                _cart.AddToCart(selectedPart, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromCart(int partId)
        {
            var selectedPart = _partRepository.GetAllParts.FirstOrDefault(p => p.PartId == partId);

            if (selectedPart != null)
            {
                _cart.RemoveFromCart(selectedPart);
            }

            return RedirectToAction("Index");
        }
    }
}
