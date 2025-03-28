using Microsoft.EntityFrameworkCore;

namespace ProductApi.Models
{
    public class ProductContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= LAPTOP-09V9BTSD; Database=ProductDb;INTEGRATED SECURITY = TRUE; Trusted_Connection=True; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial product data
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Price = 38000 },
                new Product { Id = 2, Name = "Smartphone", Price = 12000 },
                new Product { Id = 3, Name = "Headphones", Price = 1000 }
            );

        }
    }
}
