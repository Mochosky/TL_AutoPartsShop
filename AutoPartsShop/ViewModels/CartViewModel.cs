using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoPartsShop.Models;

namespace AutoPartsShop.ViewModels
{
    public class CartViewModel
    {
        public Cart Cart { get; set; }
        public decimal CartPrice { get; set; }
    }
}
