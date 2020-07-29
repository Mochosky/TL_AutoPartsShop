
using Microsoft.EntityFrameworkCore;

namespace AutoPartsShop.Models
{
    public class AutoPartsShopDbContext : DbContext
    {
        public AutoPartsShopDbContext(DbContextOptions<AutoPartsShopDbContext> options)
            : base(options) { }

        public DbSet<Part> Parts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        /// <summary>
        /// Method  to perform the data seed to the Database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.DataSeed();
        }
    }
}
