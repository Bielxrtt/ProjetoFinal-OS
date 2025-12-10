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
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name).IsRequired().HasMaxLength(45);
            builder.Property(prop => prop.Phone).IsRequired().HasMaxLength(12);
            builder.Property(prop => prop.Email).IsRequired().HasMaxLength(25);
            builder.Property(prop => prop.Adress).IsRequired().HasMaxLength(50);
            builder.Property(prop => prop.Register_Date);
            builder.Property(prop => prop.IdDevice).IsRequired().HasMaxLength(15);
            builder.Property(prop => prop.Device).IsRequired().HasMaxLength(45);
            builder.Property(prop => prop.ServiceOrders).IsRequired().HasMaxLength(250);


        }
    }
}
    
