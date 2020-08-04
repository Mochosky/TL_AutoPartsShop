using System;

using AutoPartsShop.Interfaces;
using AutoPartsShop.Models;

namespace AutoPartsShop.Repositories
{
    /// <summary>
    /// Contains the repository for the Orders.
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        private readonly AutoPartsShopDbContext _autoPartsShopDbContext;
        private readonly Cart _cart;

        public OrderRepository(AutoPartsShopDbContext autoPartsShopDbContext, Cart cart)
        {
            _autoPartsShopDbContext = autoPartsShopDbContext;
            _cart = cart;
        }

        /// <summary>
        /// Saves the Shopping Cart Order in the Database as needed.
        /// </summary>
        /// <param name="order"></param>
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _cart.GetCartPrice();

            // Add and saved the order first in the way to add order details to a no null object.
            _autoPartsShopDbContext.Add(order);
            _autoPartsShopDbContext.SaveChanges();

            var cartItems = _cart.GetCartItems();
            if (cartItems.Count > 0)
            {
                // Add order details to an existing and saved order.
                foreach (var item in cartItems)
                {
                    var orderDetail = new OrderDetail
                    {
                        Quantity = item.Quantity,
                        Price = item.Part.Price,
                        PartId = item.Part.PartId,
                        OrderId = order.OrderId,
                    };

                    _autoPartsShopDbContext.OrderDetails.Add(orderDetail);
                }

                _autoPartsShopDbContext.SaveChanges();
            }
        }
    }
}
