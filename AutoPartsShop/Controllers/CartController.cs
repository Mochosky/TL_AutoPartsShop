using System.Linq;

using AutoPartsShop.Interfaces;
using AutoPartsShop.Models;
using AutoPartsShop.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace AutoPartsShop.Controllers
{
    public class CartController : Controller
    {
        private readonly IPart _part;
        private readonly Cart _cart;

        public CartController(IPart part, Cart cart)
        {
            _part = part;
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
            var selectedPart = _part.GetAllParts.FirstOrDefault(p => p.PartId == partId);

            if (selectedPart != null)
            {
                _cart.AddToCart(selectedPart, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromCart(int partId)
        {
            var selectedPart = _part.GetAllParts.FirstOrDefault(p => p.PartId == partId);

            if (selectedPart != null)
            {
                _cart.RemoveFromCart(selectedPart);
            }

            return RedirectToAction("Index");
        }
    }
}
