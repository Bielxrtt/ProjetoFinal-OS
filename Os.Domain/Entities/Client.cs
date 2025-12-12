using Os.Domain.Base;
using Os.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Os.Domain.Entities
{
    public class Client : BaseEntity<int>
    {
      
        public Client() 
        { 
        
        }

        public Client(int id, string name, string phone, string email, string adress,
            DateTime register_Date, int idDevice, Device device, ICollection<Services> serviceOrders) : base(id)
        {
            
            Name = name;
            Phone = phone;
            Email = email;
            Adress = adress;
            Register_Date = register_Date;
            IdDevice = idDevice;
            Device = device;
            ServiceOrders = serviceOrders;
        }

        public int Id_Client { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public DateTime Register_Date { get; set; }

        public int IdDevice { get; set; }
        public Device Device { get; set; }

        
        public ICollection<Services> ServiceOrders { get; set; }

        
    }

}
