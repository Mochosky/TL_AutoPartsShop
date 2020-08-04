
using AutoPartsShop.Models;

namespace AutoPartsShop.ViewModels
{
    /// <summary>
    /// View Model to generate the Shopping Cart and Cart Price.
    /// </summary>
    public class CartViewModel
    {
        public Cart Cart { get; set; }
        public decimal CartPrice { get; set; }
    }
}
