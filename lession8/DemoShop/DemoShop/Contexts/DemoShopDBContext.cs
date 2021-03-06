using DemoShop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShop.Contexts
{
    public class DemoShopDBContext : DbContext
    {
        public DemoShopDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedingCategory(modelBuilder);
            SeedingProduct(modelBuilder);
        }

        private void SeedingCategory(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                           new Category()
                           {
                               CategoryId = 1,
                               CategoryName = "iPhone",
                               Description = "iPhone",
                               Picture = "fas fa-mobile-alt",
                               Status = true
                           },
                           new Category()
                           {
                               CategoryId = 2,
                               CategoryName = "Laptop",
                               Description = "Laptop",
                               Picture = "fas fa-laptop",
                               Status = true
                           },
                           new Category()
                           {
                               CategoryId = 3,
                               CategoryName = "PC",
                               Description = "Personal Computer",
                               Picture = "fas fa-desktop",
                               Status = true
                           });
        }

        private void SeedingProduct(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    ProductName = "iPhone 12",
                    Price = 18000000,
                    Quantity = 12,
                    Pictures = "~/images/iphone12.jpg",
                    CategoryId = 1
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "Asus",
                    Price = 12000000,
                    Quantity = 10,
                    Pictures = "~/images/laptop.jpg",
                    CategoryId = 2
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "PC",
                    Price = 13500000,
                    Quantity = 7,
                    Pictures = "~/images/pc.jpg",
                    CategoryId = 3
                });
        }
    }
}
