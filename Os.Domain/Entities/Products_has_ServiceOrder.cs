using Os.Domain.Base;

namespace Os.Domain.Entities
{
    public class Products_has_ServiceOrder : BaseEntity<int>
    {
        public int ServiceOrder_Id_Service_Order { get; set; }
        public ServiceOrder ServiceOrder { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        
        public decimal Price { get; set; }
        public float Quantity { get; set; }
    }
}