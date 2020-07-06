using System;
using System.Collections.Generic;
using WCF.Models;

namespace DataAccessLayer
{
    public class CustomerDao : ICustomerDao
    {
        public Order AddCustomer(Order customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
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

        public Order UpdateCustomer(Order customer)
        {
            throw new NotImplementedException();
        }
    }
}
