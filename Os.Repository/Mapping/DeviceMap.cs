using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Os.Domain.Entities;

namespace Os.Repository.Mapping
{
    
    public class DeviceMap : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.ToTable("Device");

            
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.TypeBrand).IsRequired();
            builder.Property(prop => prop.Model).IsRequired().HasMaxLength(25);
            builder.Property(prop => prop.Type).IsRequired().HasMaxLength(25);
            builder.Property(prop => prop.IMEI).IsRequired().HasMaxLength(15);

           
            builder.Property(prop => prop.Id_Client).IsRequired();

            builder.HasOne(d => d.Client)
                   .WithMany() 
                   .HasForeignKey(d => d.Id_Client);
        }
    }
}