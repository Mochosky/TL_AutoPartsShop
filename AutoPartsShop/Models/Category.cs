using System.Collections.Generic;

namespace AutoPartsShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Part> Parts { get; set; }
    }
}
