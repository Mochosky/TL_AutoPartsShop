using System.Collections.Generic;

using AutoPartsShop.Models;

namespace AutoPartsShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Part> PartOnSale { get; set; }
    }
}
