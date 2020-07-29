
using AutoPartsShop.Models;

namespace AutoPartsShop.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
