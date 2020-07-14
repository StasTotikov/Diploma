using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Diploma.Models
{
    public class ShopContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<CategoryProperty> CategoryProperties { get; set; }
        //public DbSet<CategoryPropertyValue> CategoryPropertyValues { get; set; }
        public DbSet<ProductValue> ProductValues { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }


        public ShopContext(DbContextOptions<ShopContext> options): base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CategoryProperty>().HasKey(t => new { t.CategoryId, t.PropertyId });
            builder.Entity<CategoryProperty>().HasOne(t => t.Category).WithMany(s => s.CategoryProperties).HasForeignKey(t => t.CategoryId);
            builder.Entity<CategoryProperty>().HasOne(t => t.Property).WithMany(s => s.CategoryProperties).HasForeignKey(t => t.PropertyId);

        }

    }
}
