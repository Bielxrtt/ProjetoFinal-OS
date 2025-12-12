using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Os.Domain.Entities;

namespace Os.Repository.Mapping
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).IsRequired().HasMaxLength(45);
            builder.Property(c => c.Phone).IsRequired().HasMaxLength(12);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(25);
            builder.Property(c => c.Adress).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Register_Date);

            
            builder.Property(c => c.IdDevice).IsRequired();
            builder.HasOne(c => c.Device).WithMany().HasForeignKey(c => c.IdDevice);
        }
    }
}