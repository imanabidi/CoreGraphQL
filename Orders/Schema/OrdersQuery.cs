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

    public class OrderStatusesEnum : EnumerationGraphType
    {
        public OrderStatusesEnum()
        {
            Name = "OrdersStatuses";
            AddValue("CREATED", "Order was created", 2);
            AddValue("PROCESSING", "Order is being processed", 4);
            AddValue("COMPLETED", "Order is completed", 8);
            AddValue("CANCELLED", "Order was cancelled", 16);
            AddValue("CLOSED", "Order was closed", 32);
        }
    }

}
