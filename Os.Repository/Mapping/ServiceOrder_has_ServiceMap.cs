using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Os.Domain.Entities;

namespace Os.Repository.Mapping
{
    public class ServiceOrder_has_ServiceMap : IEntityTypeConfiguration<ServiceOrder_has_Service>
    {
        public void Configure(EntityTypeBuilder<ServiceOrder_has_Service> builder)
        {
            builder.ToTable("ServiceOrder_has_Service");

            // PK
            builder.HasKey(prop => prop.Id);

            // FK -> ServiceOrder
            builder.Property(prop => prop.ServiceOrderId)
                .IsRequired();

            builder.HasOne(prop => prop.ServiceOrder)
                .WithMany(prop => prop.Services)
                .HasForeignKey(prop => prop.ServiceOrderId);

            // FK -> Service (Serviço)
            builder.Property(prop => prop.ServiceId)
                .IsRequired();

            builder.HasOne(prop => prop.Service)
                .WithMany()
                .HasForeignKey(prop => prop.ServiceId);

            // Campos Adicionais
            builder.Property(prop => prop.Price)
                .HasPrecision(10, 2) // Recomendado para valores monetários
                .IsRequired();
        }
    }
}