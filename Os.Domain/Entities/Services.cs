using Os.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Os.Domain.Entities
{

   
    public class Services : BaseEntity<int>
    {
        public Services() 
        {
        
        }

        public Services(int id,string TypeService, int userId, DateTime StartDate, DateTime FinishDate) : base(id)
        {
            this.TypeService = TypeService;
            UserId = userId;
            DateTime StartDate_ = StartDate;
            DateTime FinishDate_ = FinishDate;




        }

        public string TypeService { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime Finish_Date { get; set; }

        public int UserId{ get; set; }
        public UserSystem User { get; set; }

        

        public ICollection<ServiceOrder_has_Service> ServiceOrders { get; set; }
    }

}
