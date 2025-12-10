using Os.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Os.App.ViewModel
{
    public class ServicesViewModel
    {
        public string TypeService { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime Finish_Date { get; set; }

        public int UserId { get; set; }
        public UserSystem User { get; set; }



        public ICollection<ServiceOrder_has_Service> ServiceOrders { get; set; }

    }
}
