using System.Collections.Generic;
using WCF.Models;

namespace DataAccessLayer
{
    public interface IOrderDao
    {
        Order AddOrder(Order Order);
        IEnumerable<Order> GetOrders();
        void DeleteOrder(int id);
        Order UpdateOrder(Order Order);
        Order GetOrderById(int id);
        IEnumerable<Order> GetOrdersByCustomer(Order customer);
    }
}
