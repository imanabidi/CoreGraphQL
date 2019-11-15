using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Models
{
    public class Order
    {
        public Order(int amount, string name, DateTime dateTime, string id,int customerId)
        {
            Id = id;
            Name = name;
            DateTime = dateTime;
            Amount = amount;
            Status = OrderStatuses.CREATED;
            CustomerId = customerId;
        }

        public Customer Customer { get; set; }
        public string Id { get;private set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public OrderStatuses Status { get; private set; }
        public int CustomerId { get; private set; }

        internal void Start()
        {
            this.Status = OrderStatuses.PROSSESING;
        }
    }

    public enum OrderStatuses
    {
        CREATED = 2,
        PROSSESING = 4,
        COMPLETED = 8 , 
        CANCELLED = 16,
        CLOSED = 32
    }
}
