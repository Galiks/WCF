using BusinessLogicLayer;
using Container;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using WCF.Models;

namespace WCF
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        private readonly IOrderLogic orderLogic;

        public Service1()
        {
            NinjectCommon.Registration();

            orderLogic = NinjectCommon.Kernel.Get<IOrderLogic>();
        }
        public string GetData(string value)
        {
            return string.Format(value);
        }

        public Order GetCustomerById(int id)
        {
            return null;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Order> GetOrders()
        {
            return orderLogic.GetOrders().ToList();
        }

        public Order GetOrderById(int id)
        {
            return orderLogic.GetOrderById(id);
        }
    }
}
