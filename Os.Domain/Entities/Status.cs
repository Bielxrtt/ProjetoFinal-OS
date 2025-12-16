using Os.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Os.Domain.Entities
{
    public class Status : BaseEntity<int>
    {
        public Status() { }

        public Status(int id , string name, string description, DateTime startDate, DateTime finishDate) : base (id)
        { 
            
            this.Name = name;
            this.Description = description;
            this.StartDate = startDate;
            this.FinishDate = finishDate;
        
        }

        
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

        public ICollection<Services> ServiceOrders { get; set; }
        public ICollection<UserSystem> Users { get; set; }
    }

}
