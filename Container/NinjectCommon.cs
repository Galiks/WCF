using BusinessLogicLayer;
using DataAccessLayer;
using Ninject;

namespace Container
{
    public static class NinjectCommon
    {
        private static readonly IKernel kernel = new StandardKernel();

        public static IKernel Kernel => kernel;

        public static void Registration()
        {
            kernel.Bind<ICustomerDao>().To<CustomerDao>();
            kernel.Bind<IOrderDao>().To<OrderDao>();

            kernel.Bind<ICustomerLogic>().To<CustomerLogic>();
            kernel.Bind<IOrderLogic>().To<OrderLogic>();
        }
    }
}
