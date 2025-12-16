using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Os.Domain.Entities;

namespace Os.Repository.Mapping
{
    internal class ServicesMap : IEntityTypeConfiguration<Services>
    {
        public void Configure(EntityTypeBuilder<Services> builder)
        {
            builder.ToTable("Service");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.TypeService)
                .IsRequired()
                .HasMaxLength(100); 

            builder.Property(s => s.Price)
                .HasColumnType("decimal(18,2)") 
                .IsRequired();

            builder.Property(s => s.Description)
                .HasMaxLength(500); 

            
        }
    }
}