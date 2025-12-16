using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Os.Domain.Entities;

namespace Os.Repository.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name).IsRequired().HasMaxLength(100);
            builder.Property(prop => prop.Price).HasPrecision(10, 2);
            builder.Property(prop => prop.Quantity);
        }
    }
}