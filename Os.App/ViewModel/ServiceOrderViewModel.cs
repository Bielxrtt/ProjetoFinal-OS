using System;
using System.Collections.Generic;

namespace Os.App.ViewModel
{
    public class ServiceOrderViewModel
    {
        public int Id { get; set; }

        // Cabeçalho da OS
        public int IdClient { get; set; }
        public string ClientName { get; set; }

        public int IdDevice { get; set; }
        public string DeviceModel { get; set; }

        public int IdStatus { get; set; }
        public string StatusName { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public string Note { get; set; }
        public decimal TotalPrice { get; set; }

        public int IdUser { get; set; } // Técnico responsável

        // Listas para a Grid (Itens da OS)
        // Usaremos classes auxiliares simples aqui dentro mesmo
        public List<ServiceOrderItemVM> Services { get; set; } = new List<ServiceOrderItemVM>();
        public List<ProductOrderItemVM> Products { get; set; } = new List<ProductOrderItemVM>();
    }

    public class ServiceOrderItemVM
    {
        public int IdService { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductOrderItemVM
    {
        public int IdProduct { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Quantity { get; set; }
        public decimal Total => Price * (decimal)Quantity;
    }
}