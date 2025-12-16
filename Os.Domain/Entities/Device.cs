using Os.Domain.Base;
using Os.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Os.Domain.Entities
{
    public class Device : BaseEntity<int>
    {
        public Device()
        {
        }

        public Device(int id, int IdClient, TypeBrand Typebrand, string model, string type, string imei) : base(id)
        {
            Id_Client = IdClient;
            TypeBrand = Typebrand;
            Model = model;
            Type = type;
            IMEI = imei;
        }

        
        public int Id_Client { get; set; }

        public TypeBrand TypeBrand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string IMEI { get; set; }

        public Client Client { get; set; }

        public ICollection<Services> ServiceOrders { get; set; }
    }

}