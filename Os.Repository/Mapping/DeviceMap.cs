using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Os.Domain.Entities;

namespace Os.Repository.Mapping
{
    // CORREÇÃO: Adicionado ': IEntityTypeConfiguration<Device>' e alterado para 'public'
    public class DeviceMap : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.ToTable("Device");

            // É importante definir a chave primária (geralmente herdada de BaseEntity)
            builder.HasKey(prop => prop.Id);

            // Mapeamento das propriedades
            builder.Property(prop => prop.TypeBrand).IsRequired();
            builder.Property(prop => prop.Model).IsRequired().HasMaxLength(25);
            builder.Property(prop => prop.Type).IsRequired().HasMaxLength(25);
            builder.Property(prop => prop.IMEI).IsRequired().HasMaxLength(15);

            // Mapeamento da Chave Estrangeira (Id_Client)
            builder.Property(prop => prop.Id_Client).IsRequired();

            // Configuração do relacionamento com Client
            builder.HasOne(d => d.Client)
                   .WithMany() // Ajuste conforme a regra (se Client tiver lista de Devices)
                   .HasForeignKey(d => d.Id_Client);
        }
    }
}