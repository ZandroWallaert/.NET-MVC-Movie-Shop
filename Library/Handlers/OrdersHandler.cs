using System;
using System.Linq;
using System.Collections.Generic;
using howest_movie_lib.Library.Services;
using System.Collections;
using howest_movie_lib.Library.Models;
using howest_movie_shop.ViewModels.Orders;

namespace howest_movie_shop.Library.Handlers
{
    public class OrdersHandler
    {
        private ShopService shopService = new ShopService();
        private RecordService recordService = new RecordService();
        private List<Record> records = new List<Record>();

        public OrdersViewModel CreatePage()
        {
            records = recordService.GetRecords();
            foreach (var record in records)
            {
                OrdersViewModel page = new OrdersViewModel
                {
                    OrderId = record.OrderId,
                    OrderDate = record.OrderDate,
                    MovieTitles = record.MovieTitles,
                    TotalPrice = record.TotalPrice,
                    CustomerName = record.CustomerName,
                    Address = record.Address
                };
                return page;
            }
            OrdersViewModel empty = new OrdersViewModel { };
            return empty;
        }

        public ShopOrder AddOrder(long customerId, DateTime orderDate, string street, string city, string postalCode, string country) {
            return shopService.AddOrder(customerId, orderDate, street, city, postalCode, country);
        }

        public ShopCustomer AddCustomer(string userId, string name, string street, string city, string postalCode, string country) {
            return shopService.AddCustomer(userId, name, street, city, postalCode, country);
        }

        public ShopOrderDetail AddOrderDetail(long movieId, decimal moviePrice) {
            return shopService.AddOrderDetail(movieId, moviePrice);
        }

    }
}
