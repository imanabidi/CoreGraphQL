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
            Field<CustomerGraphType>("Customer",
                resolve: context =>
                            customerServices.GetCustomerByIdAsync(context.Source.CustomerId));
            Field(x => x.DateTime);
            //Field(x => x.Amount);
            Field(x => x.Description);
            Field<OrderStatusesEnum>("status",
                resolve: context => context.Source.Status);
        }
    }
}
