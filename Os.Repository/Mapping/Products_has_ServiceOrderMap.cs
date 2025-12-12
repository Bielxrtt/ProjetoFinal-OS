using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Os.Domain.Entities;

namespace Os.Repository.Mapping
{
    public class Products_has_ServiceOrderMap : IEntityTypeConfiguration<Products_has_ServiceOrder>
    {
        public void Configure(EntityTypeBuilder<Products_has_ServiceOrder> builder)
        {
            builder.ToTable("products_has_serviceorder");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Product)
                   .WithMany()
                   .HasForeignKey(x => x.ProductId); 

            builder.HasOne(prop => prop.ServiceOrder)
                   .WithMany(so => so.Products)
                   
                   .HasForeignKey(x => x.ServiceOrder_Id_Service_Order);
        }
    }
}