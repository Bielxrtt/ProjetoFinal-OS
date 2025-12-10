using Os.Domain.Entities;
using Os.Domain.Enum;


namespace Os.App.ViewModel
{
    public class DeviceViewModel
    {
        public int IdDevice { get; set; }
        public int Id_Client { get; set; }

        public TypeBrand TypeBrand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string IMEI { get; set; }

        public MySqlX.XDevAPI.Client Client { get; set; }

        // Corrigido: lista de ServiceOrder, não Service
        public ICollection<ServiceOrder> ServiceOrders { get; set; }
    }
}
