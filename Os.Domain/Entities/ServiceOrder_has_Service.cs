using Os.Domain.Base;

namespace Os.Domain.Entities
{
    public class ServiceOrder_has_Service : BaseEntity<int>
    {
        public int ServiceOrderId { get; set; }
        public ServiceOrder ServiceOrder { get; set; }

        public int ServiceId { get; set; }
        public Services Service { get; set; }

        
        public decimal Price { get; set; }
    }
}