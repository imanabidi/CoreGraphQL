using GraphQL;

namespace Orders.Schema
{
    public class OrdersSchema : GraphQL.Types.Schema
    {
        public OrdersSchema(OrdersQuery query,OrdersMutation ordersMutation,
            IDependencyResolver dependencyResolver)
        {
            this.Query = query;
            this.DependencyResolver = dependencyResolver;
            this.Mutation = ordersMutation;
        }
    }

}
