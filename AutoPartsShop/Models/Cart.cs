﻿using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AutoPartsShop.Models
{
    public class Cart
    {
        private readonly AutoPartsShopDbContext _autoPartsShopDbContext;
        public string CartId { get; set; }
        public List<CartItem> CartItems { get; set; }

        public Cart(AutoPartsShopDbContext autoPartsShopDbContext)
        {
            _autoPartsShopDbContext = autoPartsShopDbContext;
        }

        public static Cart GetCart(IServiceProvider serviceProvider)
        {
            ISession session = serviceProvider.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = serviceProvider.GetService<AutoPartsShopDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new Cart(context) { CartId = cartId };
        }

        public void AddToCart(Part part, int quantity)
        {
            var cartItem = _autoPartsShopDbContext.CartItems
                .SingleOrDefault(c => c.Part.PartId == part.PartId && c.CartId == CartId);

            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    CartId = CartId,
                    Part = part,
                    Quantity = quantity
                };

                _autoPartsShopDbContext.CartItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity++;
            }

            _autoPartsShopDbContext.SaveChanges();
        }

        public int RemoveFromCart(Part part)
        {
            var cartItem = _autoPartsShopDbContext.CartItems
               .SingleOrDefault(c => c.Part.PartId == part.PartId && c.CartId == CartId);

            int itemQuantity = 0;
            if (cartItem != null)
            {
                if (cartItem.Quantity > 1)
                {
                    cartItem.Quantity--;
                    itemQuantity = cartItem.Quantity;
                }
                else
                {
                    _autoPartsShopDbContext.CartItems.Remove(cartItem);
                }
            }
            _autoPartsShopDbContext.SaveChanges();

            return itemQuantity;
        }

        public List<CartItem> GetCartItems()
        {
            return CartItems ?? (CartItems = _autoPartsShopDbContext.CartItems
                .Where(c => c.CartId == CartId)
                .Include(q => q.Part)
                .ToList());
        }

        public void ClearCart()
        {
            var carItems = _autoPartsShopDbContext.CartItems.Where(c => c.CartId == CartId);

            _autoPartsShopDbContext.CartItems.RemoveRange(carItems);
            _autoPartsShopDbContext.SaveChanges();
        }

        public decimal GetCartPrice()
        {
            var price = _autoPartsShopDbContext.CartItems.Where(c => c.CartId == CartId)
                .Select(q => q.Part.Price * q.Quantity)
                .Sum();

            return price;
        }
    }
}
