using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConsole
{
    public class AccountNumber
    {
       
        public static string CreateAccountNumber()
        {
            Random random = new System.Random();

            int dynamicPartInt = random.Next(10000000);

            string dynamicPart = dynamicPartInt.ToString();
            const string fixedPart = "302";

            string accountNumber = fixedPart + dynamicPart;

            Console.WriteLine("Your Account Number is {0}", accountNumber);

            return accountNumber;

        }
        

    }
}
