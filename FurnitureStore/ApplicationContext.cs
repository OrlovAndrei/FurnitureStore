using FurnitureStore.Models;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStore
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();
        public DbSet<Order> Orders => Set<Order>();
        
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.Use
        //}
    }
}
