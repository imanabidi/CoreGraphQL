using Orders.Schema;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Orders.Models;

namespace Orders.Services
{
    public class OrderServices : IOrderServices
    {
        private IList<Order> _orders;

        public OrderServices()
        {
            _orders = new List<Order>() { };
            _orders.Add(new Order(1000, "250 Conference brochures", DateTime.Now, "FAEBD971-CBA5-4CED-8AD5-CC0B8D4B7827",1));
            _orders.Add(new Order(2000, "250 T-shirts", DateTime.Now.AddHours(1), "F43A4F9D-7AE9-4A19-93D9-2018387D5378",2));
            _orders.Add(new Order(3000, "500 Stickers", DateTime.Now.AddHours(20), "2D542571-EF99-4786-AEB5-C997D82E57C7",3));
            _orders.Add(new Order(4000, "10 Posters", DateTime.Now.AddHours(5), "2D542572-EF99-4786-AEB5-C997D82E57C7",4));
        }

        public Task<IEnumerable<Order>> GetOrders()
        {
            return Task.FromResult(_orders.AsEnumerable());
        }

        public Task<Order> GetOrderByIdAsync(string id)
        {
            return Task.FromResult(_orders.SingleOrDefault(x => x.Id == id));
        }

        public Task<Order> StartAsync(string id)
        {
            var order = GetOrderById(id);
            order.Start();
            return Task.FromResult(order);
        }

        private Order GetOrderById(string id)
        {
            var order = _orders.SingleOrDefault(x=>x.Id == id);

            if(order==null)
                throw new ArgumentException($"{id} does not exists in orders collection");

            return order;
        }

        public Task<Order> CreateAsync(Order order)
        {
            _orders.Add(order);
            return Task.FromResult(order);
        }
    }

    public interface IOrderServices
    {
        Task<IEnumerable<Order>> GetOrders();
        Task<Order> GetOrderByIdAsync(string id);
        Task<Order> StartAsync(string id);
        Task<Order> CreateAsync(OrderGraphType order);
    }
  
}
