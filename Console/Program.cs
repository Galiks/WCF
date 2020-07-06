using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.Models;

namespace ConsoleInterface
{
    class Program
    {
        private static readonly ServiceReferenceConsole.Service1Client client;

        static Program()
        {
            client = new ServiceReferenceConsole.Service1Client();
        }


        static void Main(string[] args)
        {
            foreach (var item in client.GetOrders())
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
    }
}
