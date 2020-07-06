using System.Collections.Generic;
using WCF.Models;

namespace BusinessLogicLayer
{
    public interface ICustomerLogic
    {
        Order AddCustomer(string name);
        IEnumerable<Order> GetCustomers();
        Order GetCustomerById(int id);
        void PutOrderToCustomer(int customerId, int orderId);
    }
}
