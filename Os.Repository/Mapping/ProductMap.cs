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
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        
    public void Configure(EntityTypeBuilder<Product> builder)
        {
            
            builder.ToTable("Product");
            builder.HasKey(prop=> prop.Id);
            builder.Property(prop => prop.Quantity);
        }
    }
    



    }

