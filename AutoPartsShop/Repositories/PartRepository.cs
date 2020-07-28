using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoPartsShop.Interfaces;
using AutoPartsShop.Models;

namespace AutoPartsShop.Repositories
{
    public class PartRepository : IPart
    {
        private readonly ICategory _category = new CategoryRepository();
        public IEnumerable<Part> GetAllParts => new List<Part>
        {
            new Part
            {
                PartId=1,
                Name= "Motorcraft Spark Plug,SP-534/SP-580",
                Brand="Motorcraft",
                Price= 7.05M,
                Description="High-quality spark plugs recommended by Ford Motor Company.",
                Category=_category.GetCategories.ToList()[0],
                IsInStock=true,
                IsOnSale=false,
                ImageUrl="https://www.amazon.com/images/I/61whJcy6-oL._AC_SL1500_.jpg",
                ImageThumbnailUrl="https://www.amazon.com/images/I/31c2Xdi4T8L._AC_US40_AA50_.jpg",
                Created=DateTime.Now.AddDays(5),
                Modified=DateTime.Now.AddDays(4)
            },
            new Part
            {
                PartId=2,
                Name= "Gates (T343) Engine Timing Belt",
                Brand="Gates",
                Price= 28.98M,
                Description="Gates Gates Timing Belts T343 (ONE PER PKG) Timing Belts (ONE PER PKG)2013-11 Ford, Fiesta, 4-Cyl. 1.6 L, Cam. Belt.",
                Category=_category.GetCategories.ToList()[0],
                IsInStock=true,
                IsOnSale=false,
                ImageUrl="https://www.amazon.com/images/I/816XAI4DRxL._AC_SL1500_.jpg",
                ImageThumbnailUrl="https://www.amazon.com/images/I/816XAI4DRxL._AC_UL115_.jpg",
                Created=DateTime.Now.AddDays(10),
                Modified=DateTime.Now.AddDays(9)
            },
            new Part
            {
                PartId=3,
                Name= "Hawk HB725B.650 Brake Pad",
                Brand="Hawk",
                Price= 78.49M,
                Description="Hawk Performance is a leading supplier of severe duty and high-performance friction products manufactured in ISO-certified facilities for the motorsports and performance automotive aftermarket. Hawk Performance products are engineered to allow users to control, command and conquer the terrain for which their vehicles are designed.",
                Category=_category.GetCategories.ToList()[2],
                IsInStock=true,
                IsOnSale=true,
                ImageUrl="https://www.amazon.com/images/I/71pLHg5TJvL._AC_SL1500_.jpg",
                ImageThumbnailUrl="https://www.amazon.com/images/I/71pLHg5TJvL._AC_UL115_.jpg",
                Created=DateTime.Now.AddDays(12),
                Modified=DateTime.Now.AddDays(12)
            }
        };

        public IEnumerable<Part> GetPartsOnSale => throw new NotImplementedException();

        public Part GetPartById(int partId)
        {
            return GetAllParts.FirstOrDefault(p => p.PartId == partId);
        }
    }
}
