
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

        /// <summary>
        /// Checkout order.
        /// </summary>
        /// <returns></returns>
        public IActionResult CheckOut()
        {
            return View();
        }

        /// <summary>
        /// Post to checkout order.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _cart.CartItems = _cart.GetCartItems();

            if (_cart.CartItems.Count == 0)
                ModelState.AddModelError("", "Your cart is empty!");

            // Verify the Order form validations and then continue the Checkout process.
            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _cart.ClearCart();

                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        /// <summary>
        /// Action result to complete the order.
        /// </summary>
        /// <returns></returns>
        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMsg = "Thank you for your purchase.";
            return View();
        }
    }
}
