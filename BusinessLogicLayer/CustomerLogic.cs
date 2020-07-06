using System;
using System.Collections.Generic;
using WCF.Models;

namespace BusinessLogicLayer
{
    public class CustomerLogic : ICustomerLogic
    {
        public Order AddCustomer(string name)
        {
            throw new NotImplementedException();
        }

        public Order GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public void PutOrderToCustomer(int customerId, int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
