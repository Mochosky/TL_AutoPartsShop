using System;

using AutoPartsShop.Interfaces;
using AutoPartsShop.Models;

namespace AutoPartsShop.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AutoPartsShopDbContext _autoPartsShopDbContext;
        private readonly Cart _cart;

        public OrderRepository(AutoPartsShopDbContext autoPartsShopDbContext, Cart cart)
        {
            _autoPartsShopDbContext = autoPartsShopDbContext;
            _cart = cart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _cart.GetCartPrice();
            _autoPartsShopDbContext.Add(order);
            _autoPartsShopDbContext.SaveChanges();

            var cartItems = _cart.GetCartItems();
            if (cartItems.Count > 0)
            {
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
