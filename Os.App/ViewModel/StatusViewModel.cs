using System;
using System.Collections.Generic;

namespace Os.App.ViewModel
{
    public class StatusViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

        public List<StatusServiceOrderVM> ServiceOrders { get; set; } = new();
    }

    public class StatusServiceOrderVM
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int IdClient { get; set; }
        public int IdDevice { get; set; }
    }
}
