using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Os.Domain.Entities;

namespace Os.Repository.Mapping
{
    public class StatusMap : IEntityTypeConfiguration<Status>
    {


        public StatusMap()
        {
        }

        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Status");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name).IsRequired().HasMaxLength(45);
            builder.Property(prop => prop.Description).IsRequired().HasMaxLength(45);
            builder.Property(prop => prop.StartDate).HasColumnType("datetime");
            builder.Property(prop => prop.FinishDate).HasColumnType("datetime");
        }
    }
}


