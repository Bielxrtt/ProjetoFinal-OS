using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Os.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Os.Repository.Mapping
{
    internal class DeviceMap
    {
        public void Configure(EntityTypeBuilder<Device> builder) 
        {
            builder.ToTable("Device");
            builder.Property(prop => prop.Id_Client);
            builder.Property(prop => prop.TypeBrand);
            builder.Property(prop => prop.Model).IsRequired().HasMaxLength(25);
            builder.Property(prop => prop.Type).IsRequired().HasMaxLength(25);
            builder.Property(prop => prop.IMEI).IsRequired().HasMaxLength(15);
        }
    }
}
