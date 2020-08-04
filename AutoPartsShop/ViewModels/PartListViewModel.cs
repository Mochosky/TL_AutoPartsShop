using System.Collections.Generic;

using AutoPartsShop.Models;

namespace AutoPartsShop.ViewModels
{
    /// <summary>
    /// View Model to generate the parts by category and search redults.
    /// </summary>
    public class PartListViewModel
    {
        public IEnumerable<Part> Parts { get; set; }
        public string CurrentCategory { get; set; }
    }
}
