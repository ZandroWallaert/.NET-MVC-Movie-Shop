using System;
using System.Collections.Generic;

namespace howest_movie_shop.ViewModels.Orders
{
    public class OrdersViewModel
    {
        public long OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<string> MovieTitles { get; set; }
        public string TotalPrice { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public List<howest_movie_shop.ViewModels.Orders.OrdersViewModel> Orders { get; set; }
    }
}
