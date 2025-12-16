using Os.Domain.Base;

namespace Os.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        public Product() { }

        public Product(int id, string name, decimal price, float quantity) : base(id)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Quantity { get; set; }
    }
}