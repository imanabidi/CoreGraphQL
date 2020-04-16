using GraphQL.Types;

namespace Orders.Schema
{
    public class OrderStatusesEnum : EnumerationGraphType
    { 
        public OrderStatusesEnum()
        {
            Name = "OrdersStatuses";
            AddValue("CREATED", "Order was created", 2);
            AddValue("PROCESSING", "Order is being processed", 4);//must be be the at end otherwise gives null without compiletime error
            AddValue("COMPLETED", "Order is completed", 8);
            AddValue("CANCELLED", "Order was cancelled", 16);
            AddValue("CLOSED", "Order was closed", 32);
        }
    }

}
