using Microsoft.EntityFrameworkCore;

namespace FirstWebApi.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Clothing" },
                new Category { Id = 3, Name = "Home & Kitchen" }
            );

            // Seed Products
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Smartphone", Price = 599.99m, CategoryId = 1 },
                new Product { Id = 2, Name = "Laptop", Price = 999.99m, CategoryId = 1 },
                new Product { Id = 3, Name = "T-Shirt", Price = 19.99m, CategoryId = 2 },
                new Product { Id = 4, Name = "Jeans", Price = 49.99m, CategoryId = 2 },
                new Product { Id = 5, Name = "Blender", Price = 29.99m, CategoryId = 3 },
                new Product { Id = 6, Name = "Coffee Maker", Price = 79.99m, CategoryId = 3 }
            );
        }
    }
}
