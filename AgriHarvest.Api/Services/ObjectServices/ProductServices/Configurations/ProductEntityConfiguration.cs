using AgriHarvest.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriHarvest.Api.Services.ObjectServices.ProductServices.Configurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasOne(p => p.Category)
                   .WithMany()
                   .HasForeignKey("category_id")
                   .IsRequired();
        }
    }
}
