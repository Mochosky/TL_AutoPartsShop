using System.Collections.Generic;

using AutoPartsShop.Models;

namespace AutoPartsShop.ViewModels
{
    /// <summary>
    /// View Model to generate the list for the Parts on Sale status and Initial items.
    /// </summary>
    public class HomeViewModel
    {
        public IEnumerable<Part> PartOnSale { get; set; }
    }
}
