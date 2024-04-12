using KalabawFoods.FrontEnd.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KalabawFoods.FrontEnd.Data
{
    public class KalabawFoodsDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        public KalabawFoodsDbContext(DbContextOptions<KalabawFoodsDbContext> options) : base(options)
        {           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Sausages"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Steaks"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Supplements"
                }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Bahay Kubo",
                    Description = "Handcrafted with care and expertise, offering a symphony of savory flavors and aromatic spices.",
                    CategoryId = 1,
                    Price = 7.99,
                    Count = 18
                },
                new Product()
                {
                    Id = 2,
                    Name = "Kalabaw Rib",
                    Description = "A culinary masterpiece crafted to elevate your dining experience.",
                    CategoryId = 2,
                    Price = 49.99,
                    Count = 4
                },
                new Product()
                {
                    Id = 3,
                    Name = "Horn Powder",
                    Description = "Harness the potent properties of horn powder to support your overall health and vitality.",
                    CategoryId = 3,
                    Price = 69.99,
                    Count = 41
                }
            );
        }
    }
}
