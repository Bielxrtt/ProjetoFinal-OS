using Os.Domain.Base;
using System.Collections.Generic;

namespace Os.Domain.Entities
{
    public class UserSystem : BaseEntity<int>
    {
        public UserSystem() { }

        public string Password { get; set; }
        public string AcessLevel { get; set; } // Adicione o { get; set; }

        public int IdStatus { get; set; }
        public Status Status { get; set; }

        // CORREÇÃO: Tipo correto é ServiceOrder
        public ICollection<ServiceOrder> ServiceOrders { get; set; }
        // Dentro de ServiceOrder.cs
        public ICollection<Products_has_ServiceOrder> Products { get; set; }
        public ICollection<ServiceOrder_has_Service> Services { get; set; }
    }
}