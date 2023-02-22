using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class ifelse
    {
        public static void Test()
        {
            Console.WriteLine("Enter ur Emailid");
            string Emailid = Console.ReadLine();

            Console.WriteLine("Enter ur Password");
            string password = Console.ReadLine();

            if (Emailid == "brijesh@123" && password == "123")
            {
                Console.WriteLine("Login Successfully");
            }
            else
            {
                Console.WriteLine("Emailid or Password is not correct!");
            }
        }
    }
}
