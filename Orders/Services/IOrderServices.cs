using System.Collections.Generic;
using System.Threading.Tasks;
using Orders.Models;

namespace Orders.Services
{
    public interface IOrderServices
    {
        Task<IEnumerable<Order>> GetOrders();
        Task<Order> GetOrderByIdAsync(string id);

        /// <summary>
        /// use to start an order virtually and lastely  change its status  to next step
        /// it is actually called with a mutation in GraphQl terms
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Order> StartAsync(string id);


        Task<Order> CreateAsync(Order order);
    }
  
}
