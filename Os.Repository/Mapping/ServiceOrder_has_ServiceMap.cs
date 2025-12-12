using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Os.Domain.Entities;

namespace Os.Repository.Mapping
{
    public class ServiceOrder_has_ServiceMap : IEntityTypeConfiguration<ServiceOrder_has_Service>
    {
        public void Configure(EntityTypeBuilder<ServiceOrder_has_Service> builder)
        {
            builder.ToTable("serviceorder_has_service");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.ServiceOrder)
                   .WithMany(so => so.Services) // Atualizaremos ServiceOrder no passo 3
                   .HasForeignKey(x => x.ServiceOrderId);

            builder.HasOne(x => x.Service)
                   .WithMany()
                   .HasForeignKey(x => x.ServiceId);
        }
    }
}