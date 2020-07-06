using DataAccessLayer;
using System;
using System.Collections.Generic;
using WCF.Models;

namespace BusinessLogicLayer
{
    public class OrderLogic : IOrderLogic
    {
        private readonly IOrderDao orderDao;

        public OrderLogic(IOrderDao orderDao)
        {
            this.orderDao = orderDao;
        }

        public Order AddOrder(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }
            else
            {
                Order order = new Order() { Name = name };
                return orderDao.AddOrder(order);
            }
        }

        public Order GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrders()
        {
            return orderDao.GetOrders();
        }

        public IEnumerable<Order> GetOrdersByCustomer(Order customer)
        {
            throw new NotImplementedException();
        }
    }
}
