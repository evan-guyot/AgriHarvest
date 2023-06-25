using AgriHarvest.Api.Models;
using AgriHarvest.Api.Services.ObjectServices.ProductServices.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AgriHarvest.Api.Services.ObjectServices.ProductServices.Contexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        {
        }

        protected ProductContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
        }

        public DbSet<Product> Products { get; set; }
    }
}
