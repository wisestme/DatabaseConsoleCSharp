using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConsole
{
    class CustomerAccount
    {
        public static void DrawHorizontalLine()
        {
            var horizontalLine = "\n -------------------- \n";
            Console.WriteLine(horizontalLine);
        }

        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public void GetCustomerInfo()
        {
            Console.WriteLine("Please fill in your details");
            DrawHorizontalLine();

            Console.WriteLine("What is your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter your phone number");
            phone = Console.ReadLine();

            Console.WriteLine("Enter Your Email Address");
            email = Console.ReadLine();
        }
    }
}
