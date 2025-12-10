
using Os.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;


using Os.Domain.Base;
namespace Os.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        public Product()
        {

        }

        public Product(int id, float quantity) : base(id)
        {


            Quantity = quantity;


        }

    public float Quantity { get; set; }

    }
}
