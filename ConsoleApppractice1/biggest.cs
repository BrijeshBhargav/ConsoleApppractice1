using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class biggest
    {
        public static void test2()
        {
            int num1, num2, num3;
            Console.WriteLine("enter num1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ("enter num2");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("eneter num3");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is greater");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("num2 is grater");
            }
            else
            {
                Console.WriteLine("num3 is greater");
            }
                    }
    }
}
