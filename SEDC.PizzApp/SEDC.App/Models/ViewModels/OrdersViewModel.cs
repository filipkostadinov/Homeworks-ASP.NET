using SEDC.App.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.App.Models.ViewModels
{
    public class OrdersViewModel
    {
        public string Pizza { get; set; }
        public int NumberOfOrders { get; set; }
        public string PersonName { get; set; }
        public double Price { get; set; }
    }
}
