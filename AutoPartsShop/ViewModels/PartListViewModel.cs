using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoPartsShop.Models;

namespace AutoPartsShop.ViewModels
{
    public class PartListViewModel
    {
        public IEnumerable<Part> Parts { get; set; }
        public string CurrentCategory { get; set; }
    }
}
