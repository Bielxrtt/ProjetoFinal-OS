using Os.Domain.Base;
using System;

namespace Os.Domain.Entities
{
    public class Services : BaseEntity<int>
    {
        public Services()
        {
        }

        public Services(int id, string typeService, decimal price, string description) : base(id)
        {
            TypeService = typeService;
            Price = price;
            Description = description;
        }

        public string TypeService { get; set; }
        public decimal Price { get; set; }      
        public string Description { get; set; } 
       
    }
}