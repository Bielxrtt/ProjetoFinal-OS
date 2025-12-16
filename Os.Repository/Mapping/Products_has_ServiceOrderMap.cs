using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Os.Domain.Entities;

namespace Os.Repository.Mapping
{
    public class Products_has_ServiceOrderMap : IEntityTypeConfiguration<Products_has_ServiceOrder>
    {
        public void Configure(EntityTypeBuilder<Products_has_ServiceOrder> builder)
        {
            builder.ToTable("Products_has_ServiceOrder");

            builder.HasKey(prop => prop.Id);

            
            builder.Property(prop => prop.ProductId).IsRequired();
            builder.HasOne(prop => prop.Product).WithMany().HasForeignKey(prop => prop.ProductId);

            
            builder.Property(prop => prop.ServiceOrder_Id_Service_Order).IsRequired();
            builder.HasOne(prop => prop.ServiceOrder)
                .WithMany(prop => prop.Products)
                .HasForeignKey(prop => prop.ServiceOrder_Id_Service_Order);

            
            builder.Property(prop => prop.Price).HasPrecision(10, 2).IsRequired();
            builder.Property(prop => prop.Quantity).IsRequired();
        }
    }
}