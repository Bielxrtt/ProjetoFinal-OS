using Os.Domain.Base;

using System;

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



        // Propriedades Simples

        public DateTime StartDate { get; set; } // Adicionado

        public decimal Price { get; set; }

        public string Note { get; set; }



        // Chaves Estrangeiras e Navegação

        public int IdStatus { get; set; }

        public Status Status { get; set; }



        public int UserId { get; set; }

        public UserSystem User { get; set; }



        public int IdClient { get; set; }

        public Client Client { get; set; }



        public int IdDevice { get; set; }

        public Device Device { get; set; }



        // Listas (Relacionamentos)

        public ICollection<ServiceOrder_has_Service> Services { get; set; }

        public ICollection<Products_has_ServiceOrder> Products { get; set; }

    }

}