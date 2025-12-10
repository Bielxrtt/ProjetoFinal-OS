using Os.Domain.Base;
using System.Collections.Generic;

namespace Os.Domain.Entities
{
    
    public class ServiceOrder : BaseEntity<int>
    {
        public ServiceOrder()
        {
            Services = new List<ServiceOrder_has_Service>();
            Products = new List<Products_has_ServiceOrder>();
        }

        public ServiceOrder(
            int id,
            decimal price,
            string note,
            int idStatus,
            Status status,
            int userId,
            UserSystem user,
            int idClient,
            Client client,
            int idDevice,
            Device device,
            ICollection<ServiceOrder_has_Service> services,
            ICollection<Products_has_ServiceOrder> products
        ) : base(id)
        {
            Price = price;
            Note = note;
            IdStatus = idStatus;
            Status = status;
            UserId = userId;
            User = user;
            IdClient = idClient;
            Client = client;
            IdDevice = idDevice;
            Device = device;
            Services = services;
            Products = products;
        }

        public decimal Price { get; set; }
        public string Note { get; set; }

        
        public int IdStatus { get; set; }
        public Status Status { get; set; }

        public int UserId { get; set; }
        public UserSystem User { get; set; }

        public int IdClient { get; set; }
        public Client Client { get; set; }

        public int IdDevice { get; set; }
        public Device Device { get; set; }

        // N:N
        public ICollection<ServiceOrder_has_Service> Services { get; set; }
        public ICollection<Products_has_ServiceOrder> Products { get; set; }
    }

   
    public class Products_has_ServiceOrder : BaseEntity<int>
    {
        public Products_has_ServiceOrder() { }

        public Products_has_ServiceOrder(
            int id,
            int productId,
            Product product,
            int serviceOrderId,
            ServiceOrder serviceOrder
        ) : base(id)
        {
            ProductId = productId;
            Product = product;
            ServiceOrder_Id_Service_Order = serviceOrderId;
            ServiceOrder = serviceOrder;
        }

        // FK → Product
        public int ProductId { get; set; }
        public Product Product { get; set; }

        // FK → ServiceOrder
        public int ServiceOrder_Id_Service_Order { get; set; }
        public ServiceOrder ServiceOrder { get; set; }
    }

    
    public class ServiceOrder_has_Service : BaseEntity<int>
    {
        public ServiceOrder_has_Service() { }

        public ServiceOrder_has_Service(int id) : base(id) { }

        // FK → ServiceOrder
        public int ServiceOrder_Id_Service_Order { get; set; }
        public ServiceOrder ServiceOrder { get; set; }

        // FK → Service
        public int ServiceId { get; set; }
        public Services Service { get; set; }

        
        public string Service_TypeService { get; set; }
        public int Service_Item_TypeItem { get; set; }
    }
}
