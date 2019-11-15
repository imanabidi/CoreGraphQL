using Orders.Models;
using GraphQL.Types;

namespace Orders.Schema
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Field(x=>x.Id);
            Field(x=>x.Name);
        }
    }
}
