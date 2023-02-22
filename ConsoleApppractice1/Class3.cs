using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class Class3
    {
        public static void test()
        {
            double avg;
            Console.WriteLine("enter n1");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter n2");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter n3");
            double n3 = Convert.ToDouble(Console.ReadLine());

            avg = (n1 + n2 + n3) / 3;
            Console.WriteLine("average of 3 numbers :" + avg);
        }
    }
}
