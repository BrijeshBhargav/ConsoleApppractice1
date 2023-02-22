using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class dollar
    {
        public static void test()
        {
            Single dollar_amnt;
            int cents;
            Console.WriteLine("enter dollar ");
            dollar_amnt = Convert.ToSingle(Console.ReadLine());
            cents =(int) (dollar_amnt * 100);
            Console.WriteLine("after converting to cents : " + cents);


        }
    }
}
