using Orders.Models;
using GraphQL.Types;

namespace Orders.Schema
{
    public class CustomerGraphType : ObjectGraphType<Customer>
    {
        public CustomerGraphType()
        {
            Field(x=>x.Id);
            Field(x=>x.Name);
        }
    }
}
