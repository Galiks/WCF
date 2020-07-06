using System.Collections.Generic;
using WCF.Models;

namespace BusinessLogicLayer
{
    public interface IOrderLogic
    {
        Order AddOrder(string name);
        IEnumerable<Order> GetOrders();
        Order GetOrderById(int id);
        IEnumerable<Order> GetOrdersByCustomer(Order customer);
    }
}
