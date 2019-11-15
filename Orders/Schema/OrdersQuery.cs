using GraphQL.Types;
using Orders.Services;

namespace Orders.Schema
{
    public class OrdersQuery : ObjectGraphType<object>
    {
        public OrdersQuery(IOrderServices orderServices)
        {
            Name = "OrdersQuery";
            Field<ListGraphType<OrderGraphType>>("Orders",
                                        resolve: x => orderServices.GetOrders());

        }
    }

}
