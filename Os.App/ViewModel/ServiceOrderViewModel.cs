namespace Os.App.ViewModel
{
    public class ServiceOrderViewModel
    {
        public int Id { get; set; }

        public decimal Price { get; set; }
        public string Note { get; set; }

        public int IdStatus { get; set; }
        public int UserId { get; set; }
        public int IdClient { get; set; }
        public int IdDevice { get; set; }

        public List<ServiceOrderServiceVM> Services { get; set; } = new();
        public List<ServiceOrderProductVM> Products { get; set; } = new();
    }

    public class ServiceOrderServiceVM
    {
        public int Id { get; set; } // Id da tabela N:N
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }

        public string Service_TypeService { get; set; }
        public int Service_Item_TypeItem { get; set; }
    }

    public class ServiceOrderProductVM
    {
        public int Id { get; set; } // Id da tabela N:N
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
