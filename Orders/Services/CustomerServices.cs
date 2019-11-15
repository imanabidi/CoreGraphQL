using System;
using System.Collections.Generic;
using System.Linq;
using Orders.Models;

namespace Orders.Services
{
    public class  CustomerServices :ICustomerServices 
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

        public IEnumerable<Customer> GetCustomers()
        {
            return _customers.AsEnumerable();
        }

        public Customer GetCustomerById(int id)
        {
            return _customers.SingleOrDefault(x=>x.Id==id);
        }
        

    }

      public interface ICustomerServices
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(int id);
    }
}