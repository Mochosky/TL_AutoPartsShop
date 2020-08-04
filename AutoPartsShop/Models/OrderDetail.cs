using System.ComponentModel.DataAnnotations;

namespace AutoPartsShop.Models
{
    /// <summary>
    /// Model with the Orde Detail object and properties.
    /// </summary>
    public class OrderDetail : BaseEntity
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int PartId { get; set; }
        public Part Part { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
