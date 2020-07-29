
using AutoPartsShop.Models;
using AutoPartsShop.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace AutoPartsShop.Components
{
    public class CartSummary : ViewComponent
    {
        private readonly Cart _cart;

        public CartSummary(Cart cart)
        {
            _cart = cart;
        }

        public IViewComponentResult Invoke()
        {
            _cart.CartItems = _cart.GetCartItems();

            var cartViewModel = new CartViewModel
            {
                Cart = _cart,
                CartPrice = _cart.GetCartPrice()
            };

            return View(cartViewModel);
        }
    }
}
