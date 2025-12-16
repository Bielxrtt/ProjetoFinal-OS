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

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Price).HasPrecision(10, 2).IsRequired();
            builder.Property(prop => prop.Note).HasMaxLength(500);
            builder.Property(prop => prop.Date).IsRequired(); 
            

            
            builder.HasOne(prop => prop.Status).WithMany().HasForeignKey(prop => prop.IdStatus);
            builder.HasOne(prop => prop.User).WithMany().HasForeignKey(prop => prop.UserId);
            builder.HasOne(prop => prop.Client).WithMany().HasForeignKey(prop => prop.IdClient);
            builder.HasOne(prop => prop.Device).WithMany().HasForeignKey(prop => prop.IdDevice);

           
            builder.HasMany(prop => prop.Services)
                .WithOne(prop => prop.ServiceOrder)
                .HasForeignKey(prop => prop.ServiceOrderId); 

            builder.HasMany(prop => prop.Products)
                .WithOne(prop => prop.ServiceOrder)
                .HasForeignKey(prop => prop.ServiceOrder_Id_Service_Order);
        }
    }
}