using System.Collections.Generic;
using System.Threading.Tasks;
using Orders.Models;

namespace Orders.Services
{
    public interface ICustomerServices
    {
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomerByIdAsync(int id);
    }
}