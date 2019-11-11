using Orders.Models;
using System;
using System.Collections.Generic;
using System.Text;
using GraphQL;
using GraphQL.Types;
using Orders.Services;

namespace Orders.Schema
{
    public class OrderGraphType : GraphQL.Types.ObjectGraphType<Order>
    {
        public OrderGraphType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.DateTime);
            Field(x => x.Amount);
        }
    }


    public class OrdersQuery : ObjectGraphType<object>
    {
        public OrdersQuery(IOrderServices orderServices)
        {
            Name = "Query";
            Field<ListGraphType<OrderGraphType>>("Orders",
                                        resolve: x => orderServices.GetOrders());

        }
    }


    public class OrdersSchema : GraphQL.Types.Schema
    {
        public OrdersSchema(OrdersQuery query, IDependencyResolver dependencyResolver)
        {
            this.Query = query;
            this.DependencyResolver = dependencyResolver;
        }
    }

}
