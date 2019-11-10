﻿using Orders.Schema;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Orders.Models;

namespace Orders.Services
{
    public class OrderServices : IOrderServices
    {
        private List<Order> _orders;

        public OrderServices()
        {
            _orders = new List<Order>() { };
            _orders.Add(new Order(1000, "250 Conference brochures", DateTime.Now, "FAEBD971-CBA5-4CED-8AD5-CC0B8D4B7827"));
            _orders.Add(new Order(2000, "250 T-shirts", DateTime.Now.AddHours(1), "F43A4F9D-7AE9-4A19-93D9-2018387D5378"));
            _orders.Add(new Order(3000, "500 Stickers", DateTime.Now.AddHours(2), "2D542571-EF99-4786-AEB5-C997D82E57C7"));
            _orders.Add(new Order(4000, "10 Posters", DateTime.Now.AddHours(2), "2D542572-EF99-4786-AEB5-C997D82E57C7"));
        }

        public IEnumerable<Order> GetOrders()
        {
            return _orders;
        }

        public Order GetOrderById(string id)
        {
            return _orders.SingleOrDefault(x => x.Id == id);
        }
    }

    public interface IOrderServices
    {
        IEnumerable<Order> GetOrders();
        Order GetOrderById(string id);
    }
}