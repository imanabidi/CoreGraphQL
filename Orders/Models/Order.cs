using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Models
{
    public class Order
    {
        public Order(int amount, string name, DateTime dateTime, string id)
        {
            Id = id;
            Name = name;
            DateTime = dateTime;
            Amount = amount;
        }

        public string Id { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
    }
}
