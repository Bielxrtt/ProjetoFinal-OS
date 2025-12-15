using Os.Domain.Entities;
using System.Collections.Generic;

namespace Os.App.ViewModel
{
    public class UserSystemViewModel
    {
        
        public int Id { get; set; }

        
        public string Name { get; set; }
        public string Login { get; set; }
        

        public string Password { get; set; }
        public string AcessLevel { get; set; }

        public int IdStatus { get; set; }
        public Status Status { get; set; }

        public ICollection<ServiceOrder> ServiceOrders { get; set; }
    }
}