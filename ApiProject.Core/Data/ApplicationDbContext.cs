using ApiProject.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Product>? Products { get; set; }
        public DbSet<Order>? Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Ipad Pro",
                    Price = 999
                },
                new Product
                {
                    Id = 2,
                    Name = "Bose Headphones",
                    Price = 399
                },
                new Product
                {
                    Id = 3,
                    Name = "Wireless Charger",
                    Price = 20
                }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "John Doe",
                },
                new Order
                {
                    Id = 2,
                    ProductId = 2,
                    Name = "John Doe",
                }
            );
        }
    }
}
