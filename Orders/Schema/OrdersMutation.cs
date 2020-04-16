using GraphQL.Types;
using Orders.Models;
using Orders.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Schema
{
    public class OrdersMutation : ObjectGraphType<object>
    {
        public OrdersMutation(IOrderServices orderService)
        {
            Name = "Mutations";

            Field<OrderGraphType>(
                "createOrder",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<OrderCreateInputType>>()
                    {
                        Description = "Order Input description sample",
                        Name = "order"
                    }), resolve: context =>
                    {
                        var inputOrder = context.GetArgument<OrderCreateInput>("order");
                        var guid = Guid.NewGuid().ToString();
                        var order = new Order(inputOrder.Name, inputOrder.Description,
                            inputOrder.Created, inputOrder.CustomerId, guid);

                        return orderService.CreateAsync(order);
                    });

            FieldAsync<OrderGraphType>(
                "startOrder",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>>()
                    {
                        Name = "orderId"
                    }), resolve: async context =>
                    {
                        var inputOrderId = context.GetArgument<string>("orderId");

                        return await context.TryAsyncResolve(
                            async c=> await  orderService.StartAsync(inputOrderId));
                    });
        }

    }
}
