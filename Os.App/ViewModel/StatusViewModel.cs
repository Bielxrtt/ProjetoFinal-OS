using System;
using System.Collections.Generic;

namespace Os.App.ViewModel
{
    public class StatusViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class StatusServiceOrderVM
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int IdClient { get; set; }
        public int IdDevice { get; set; }
    }
}
