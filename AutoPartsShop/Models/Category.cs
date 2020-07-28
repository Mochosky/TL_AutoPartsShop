using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoPartsShop.Models
{
    public class Category : BaseEntity
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Part> Parts { get; set; }
    }
}
