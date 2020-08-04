
using AutoPartsShop.Models;

namespace AutoPartsShop.Interfaces
{
    /// <summary>
    /// Interface that contains the contract for Repository and DI.
    /// </summary>
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
