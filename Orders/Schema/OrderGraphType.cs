using Orders.Models;
using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;
using Orders.Services;

namespace Orders.Schema
{
    public class OrderGraphType : ObjectGraphType<Order>
    {
        public OrderGraphType(ICustomerServices customerServices)
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field<CustomerType>("Customer" ,resolve: context=> customerServices.GetCustomerById( context.Source.CustomerId));
            Field(x => x.DateTime);
            Field(x => x.Amount);
        }
    }

    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Field(x=>x.Id);
            Field(x=>x.Name);
        }
    }
}
