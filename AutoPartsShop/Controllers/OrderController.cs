
using AutoPartsShop.Interfaces;
using AutoPartsShop.Models;

using Microsoft.AspNetCore.Mvc;

namespace AutoPartsShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly Cart _cart;

        public OrderController(IOrderRepository orderRepository, Cart cart)
        {
            _orderRepository = orderRepository;
            _cart = cart;
        }

        public IActionResult CheckOut()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _cart.CartItems = _cart.GetCartItems();

            if (_cart.CartItems.Count == 0)
                ModelState.AddModelError("", "Your cart is empty!");

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _cart.ClearCart();

                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMsg = "Thank you for your purchase.";
            return View();
        }
    }
}
