using Os.Domain.Base;
using System.Collections.Generic;

namespace Os.Domain.Entities
{
    public class UserSystem : BaseEntity<int>
    {
        public UserSystem() { }

        
        public string Name { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }
        public string AcessLevel { get; set; }

        public int IdStatus { get; set; }
        public Status Status { get; set; }

        public ICollection<ServiceOrder> ServiceOrders { get; set; }
        public ICollection<Services> Services { get; set; }
    }
}