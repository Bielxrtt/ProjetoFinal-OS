using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Os.Domain.Entities;

namespace Os.Repository.Mapping
{
    public class UserSystemMap : IEntityTypeConfiguration<UserSystem>
    {
        public void Configure(EntityTypeBuilder<UserSystem> builder)
        {
            builder.ToTable("UserSystem");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Password).IsRequired().HasMaxLength(255);
            builder.Property(u => u.AcessLevel).IsRequired().HasMaxLength(50);

            builder.Property(u => u.IdStatus).IsRequired();
            builder.HasOne(u => u.Status).WithMany().HasForeignKey(u => u.IdStatus);
        }
    }
}