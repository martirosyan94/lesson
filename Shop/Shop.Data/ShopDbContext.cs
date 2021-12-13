using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(e => e.Id);
            modelBuilder.Entity<Product>().HasMany(e => e.ProductOrders).WithOne(e => e.Product).HasForeignKey(e => e.ProductId);
            modelBuilder.Entity<Order>().HasKey(e => e.Id);
            modelBuilder.Entity<Order>().HasMany(e => e.ProductOrders).WithOne(e => e.Order).HasForeignKey(e => e.OrderId);
            modelBuilder.Entity<ProductOrder>().HasKey(e => new { e.OrderId, e.ProductId });
         //   modelBuilder.Entity<User>().HasKey(e => e.Id);
         //   modelBuilder.Entity<User>().HasMany(e => e.UserOrders).WithOne(e => e.User).HasForeignKey(e => e.UserId);
         //   modelBuilder.Entity<UserOrder>().HasKey(e => new { e.OrderId, e.UserId });
         //   modelBuilder.Entity<User>().HasKey(e => e.Id);
         //   modelBuilder.Entity<User>().HasMany(e => e.UserProducts).WithOne(e => e.User).HasForeignKey(e => e.UserId);
         //   modelBuilder.Entity<UserProduct>().HasKey(e => new { e.ProductId, e.UserId });

            base.OnModelCreating(modelBuilder);
        }

    }
}
