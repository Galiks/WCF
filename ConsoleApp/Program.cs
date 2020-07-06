using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
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
            Console.WriteLine("HELLO!");
            Console.WriteLine(client.GetOrderById(3)?.Name);
            Console.ReadLine();
        }
    }
}
