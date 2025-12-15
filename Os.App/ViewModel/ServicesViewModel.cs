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
        public int Id { get; set; }
        public string TypeService { get; set; } // Nome do Serviço
        public decimal Price { get; set; }      // Preço Base
        public string Description { get; set; }
    }

    }

