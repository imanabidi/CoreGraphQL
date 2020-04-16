using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Models
{
    public class Order
    {
        // it is written for the amount which is not used in main model
        //public Order(int amount, string name, DateTime dateTime, string id, int customerId)
        //{
        //    Id = id;
        //    Name = name;
        //    DateTime = dateTime;
        //    Amount = amount;
        //    Status = OrderStatuses.CREATED;
        //    CustomerId = customerId;
        //}
        // main from tutorial
        public Order(string name, string description, DateTime created, int customerId, string Id)
        {
            Name = name;
            Description = description;
            Created = created;
            CustomerId = customerId;
            this.Id = Id;
            Status = OrderStatuses.CREATED;
        }

        public DateTime Created { get; set; }

        public string Description { get; set; }

        public Customer Customer { get; set; }
        public string Id { get; private set; }
        //public int Amount { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public OrderStatuses Status { get; private set; }
        public int CustomerId { get; private set; }

        internal void Start()
        {
            this.Status = OrderStatuses.PROSSESING;
        }
    }
}
