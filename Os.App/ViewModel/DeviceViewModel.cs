using Os.Domain.Entities;
using Os.Domain.Enum;


namespace Os.App.ViewModel
{
    public class DeviceViewModel
    {
        public int Id{ get; set; }
        public int Id_Client { get; set; }
        public string ClientName { get; set; }

        public TypeBrand TypeBrand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string IMEI { get; set; }
    }
}