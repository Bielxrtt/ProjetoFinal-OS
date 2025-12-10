using Os.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Os.App.ViewModel
{
   public class ClientViewModel
    {
        public int Id_Client { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public DateTime Register_Date { get; set; }
        public int IdDevice { get; set; }
        public Device Device { get; set; }

    }
}
