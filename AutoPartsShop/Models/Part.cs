namespace AutoPartsShop.Models
{
    public class Part : BaseEntity
    {
        public int PartId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsInStock { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
