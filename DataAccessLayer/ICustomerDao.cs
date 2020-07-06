using System.Collections.Generic;
using WCF.Models;

namespace DataAccessLayer
{
    public interface ICustomerDao
    {
        Order AddCustomer(Order customer);
        IEnumerable<Order> GetCustomers();
        void DeleteCustomer(int id);
        Order UpdateCustomer(Order customer);
        Order GetCustomerById(int id);
        void PutOrderToCustomer(int customerId, int orderId);
    }
}
