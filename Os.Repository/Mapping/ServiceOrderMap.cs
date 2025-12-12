using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Os.Domain.Entities;

namespace Os.Repository.Mapping
{
    internal class ServiceOrderMap : IEntityTypeConfiguration<ServiceOrder>
    {
        public void Configure(EntityTypeBuilder<ServiceOrder> builder)
        {
            builder.ToTable("ServiceOrder");

            // PK
            builder.HasKey(prop => prop.Id);

            // CAMPOS
            builder.Property(prop => prop.Price)
                .IsRequired();

            builder.Property(prop => prop.Note)
                .HasMaxLength(500);

            // FK → Status
            builder.Property(prop => prop.IdStatus)
                .IsRequired();

            builder.HasOne(prop => prop.Status)
                .WithMany()
                .HasForeignKey(prop => prop.IdStatus);

            // FK → UserSystem
            builder.Property(prop => prop.UserId)
                .IsRequired();

            builder.HasOne(prop => prop.User)
                .WithMany()
                .HasForeignKey(prop => prop.UserId);

            // FK → Client
            builder.Property(prop => prop.IdClient)
                .IsRequired();

            builder.HasOne(prop => prop.Client)
                .WithMany()
                .HasForeignKey(prop => prop.IdClient);

            // FK → Device
            builder.Property(prop => prop.IdDevice)
                .IsRequired();

            builder.HasOne(prop => prop.Device)
                .WithMany()
                .HasForeignKey(prop => prop.IdDevice);

            // RELACIONAMENTO N:N → Serviços
            builder.HasMany(prop => prop.Services)
                .WithOne(prop => prop.ServiceOrder)
                .HasForeignKey(prop => prop.ServiceId);

            // RELACIONAMENTO N:N → Produtos
            builder.HasMany(prop => prop.Products)
                .WithOne(prop => prop.ServiceOrder)
                .HasForeignKey(prop => prop.ServiceOrder_Id_Service_Order);
        }
    }

   
    public class ProductsHasServiceOrderMap : IEntityTypeConfiguration<Products_has_ServiceOrder>
    {
        public void Configure(EntityTypeBuilder<Products_has_ServiceOrder> builder)
        {
            builder.ToTable("Products_has_ServiceOrder");

            
            builder.HasKey(prop => prop.Id);

            
            builder.Property(prop => prop.ProductId)
                .IsRequired();

            builder.HasOne(prop => prop.Product)
                .WithMany()
                .HasForeignKey(prop => prop.ProductId);

            
            builder.Property(prop => prop.ServiceOrder_Id_Service_Order)
                .IsRequired();

            builder.HasOne(prop => prop.ServiceOrder)
                .WithMany(prop => prop.Products)
                .HasForeignKey(prop => prop.ServiceOrder_Id_Service_Order);
        }
    }

   
    public class ServiceOrderHasServiceMap : IEntityTypeConfiguration<ServiceOrder_has_Service>
    {
        public void Configure(EntityTypeBuilder<ServiceOrder_has_Service> builder)
        {
            builder.ToTable("ServiceOrder_has_Service");

            
            builder.HasKey(prop => prop.Id);

            
            builder.Property(prop => prop.ServiceOrderId)
                .IsRequired();

            builder.HasOne(prop => prop.ServiceOrder)
                .WithMany(prop => prop.Services)
                .HasForeignKey(prop => prop.ServiceOrderId);

            
            builder.Property(prop => prop.ServiceId)
                .IsRequired();

            builder.HasOne(prop => prop.Service)
                .WithMany()
                .HasForeignKey(prop => prop.ServiceId);

            
            builder.Property(prop => prop.Service_TypeService)
                .HasMaxLength(200);

            builder.Property(prop => prop.Service_Item_TypeItem)
                .IsRequired();
        }
    }
}
