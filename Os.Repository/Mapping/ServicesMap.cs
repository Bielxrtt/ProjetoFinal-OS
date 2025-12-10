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
                .HasMaxLength(45);

            builder.Property(s => s.UserId)
                .IsRequired();

            builder.Property(s => s.Start_Date)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(s => s.Finish_Date)
                .HasColumnType("datetime")
                .IsRequired();

            // RELACIONAMENTO COM USER
            builder.HasOne(s => s.User)
                .WithMany(u => u.Services)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
