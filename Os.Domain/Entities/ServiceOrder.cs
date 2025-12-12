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
}


   
   