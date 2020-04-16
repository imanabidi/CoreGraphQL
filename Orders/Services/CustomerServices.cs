using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Orders.Models;

namespace Orders.Services
{
    public class CustomerServices : ICustomerServices
    {
        private IList<Customer> _customers;

        public CustomerServices()
        {
            _customers = new List<Customer>();
            _customers.Add(new Customer(1, "KinetEco"));
            _customers.Add(new Customer(2, "Pixelford Photography"));
            _customers.Add(new Customer(3, "Topsy Turvy"));
            _customers.Add(new Customer(4, "Leaf & Mortar"));
        }

        public Task<IEnumerable<Customer>> GetCustomers()
        {
            return Task.FromResult(_customers.AsEnumerable());
        }

        public Task<Customer> GetCustomerByIdAsync(int id)
        {
            return Task.FromResult(_customers.SingleOrDefault(x => x.Id == id));
        }


    }
}