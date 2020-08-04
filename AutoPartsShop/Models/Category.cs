using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoPartsShop.Models
{
    /// <summary>
    /// Model with the Category object and properties.
    /// </summary>
    public class Category : BaseEntity
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Part> Parts { get; set; }
    }
}
