using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseConsole
{
    class Program
    {
        static void Main()
        {
            SqlConnection conn, con;
            String str, strg;
            //string name;
            //int age;

            try
            {
                strg = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wisestMe\source\repos\DatabaseConsole\DatabaseConsole\PracticeDB.mdf;Integrated Security=True";
                con = new SqlConnection(strg);
                con.Open();
                Console.WriteLine("Connected to database");

                CustomerAccount customerData = new CustomerAccount();
                customerData.GetCustomerInfo();

                string uniqueNumber = AccountNumber.CreateAccountNumber();
                int accountBalance = 0;

                string data = "INSERT INTO CUSTOMERACCOUNT (name, phone, email, accountNumber, accountBalance) VALUES('" + customerData.name + "', " + customerData.phone + ", '" + customerData.email + "', " + uniqueNumber + ", '" + accountBalance + "')";

                SqlCommand attach = new SqlCommand(data, con);
                attach.ExecuteNonQuery();
                Console.WriteLine("\nData stored into database");
            }
            catch (SqlException x)
            {
                Console.WriteLine(x.Message);
            }

            try
            {
                str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wisestMe\source\repos\DatabaseConsole\DatabaseConsole\PracticeDB.mdf;Integrated Security=True";
                conn = new SqlConnection(str);
                conn.Open();
                Console.WriteLine("Database connected");

                //Console.WriteLine("Enter your name: ");
                //name = Console.ReadLine();
                //Console.WriteLine("Enter your age: ");
                //age = Int32.Parse(Console.ReadLine());
                CustomerInfo customerDetails = new CustomerInfo();
                customerDetails.GetCustomerInfo();

                string query = "INSERT INTO Details (userName, userAge) VALUES('"+customerDetails.name+"', "+customerDetails.age+")";

                SqlCommand ins = new SqlCommand(query, conn);
                ins.ExecuteNonQuery();
                Console.WriteLine("\nData stored into database");

                //string q = "SELECT * FROM DETAILS";

                //SqlCommand view = new SqlCommand(q, conn);

                //SqlDataReader dr = view.ExecuteReader();

                //while (dr.Read())
                //{
                //    Console.WriteLine("Name: " + dr.GetValue(1).ToString());
                //    Console.WriteLine("Age: " + dr.GetValue(2).ToString());
                //}
                //conn.Close();
            }
            catch (SqlException x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
