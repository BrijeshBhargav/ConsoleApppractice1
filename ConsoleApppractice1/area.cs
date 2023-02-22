using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class area
    {
        public static void test()
        {
            int area;
            Console.WriteLine("enter length");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter width");
            int width = Convert.ToInt32(Console.ReadLine());
            area = length * width;
            Console.WriteLine("area is :"+area);
            Console.ReadLine();        }
    }
}
