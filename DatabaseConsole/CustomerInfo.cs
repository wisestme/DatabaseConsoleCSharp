using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConsole
{
    class CustomerInfo
    {
        public string name { get; set; }
        public int age { get; set; }
        public void GetCustomerInfo()
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = Int32.Parse(Console.ReadLine());
        }
    }
}
