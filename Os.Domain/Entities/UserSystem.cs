using Os.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Os.Domain.Entities
{
    public class UserSystem : BaseEntity<int>
    {
        public UserSystem() { }
        public UserSystem(int id, string password, string acessLevel) : base(id)
        { 

            Password = password;
            AcessLevel = acessLevel;
        }
        public int IdUser { get; set; }
        public string Password { get; set; }
        public string AcessLevel { get; }
      

        public int IdStatus { get; set; }
        public Status Status { get; set; }

        // Relacionamentos
        public ICollection<Services> ServiceOrders { get; set; }
        public ICollection<Services> Services { get; set; }
    }

}
