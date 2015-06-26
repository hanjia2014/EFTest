using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasKey(c => c.CategoryID);
            modelBuilder.Entity<Category>().Property(p => p.Name).HasColumnType("VARCHAR").IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Product>().HasKey(p => p.ProductID);
            modelBuilder.Entity<Product>().Property(p => p.Name).HasColumnType("VARCHAR").IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("DECIMAL").IsRequired();

            modelBuilder.Entity<Product>().HasRequired(m => m.Category).WithMany().HasForeignKey(c => c.CatID);

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}
