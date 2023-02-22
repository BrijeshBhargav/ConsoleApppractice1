using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class Class4
    {
        public void demo()
        {
            int i, amstr = 1, number;
            Console.WriteLine("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                amstr = amstr * i;
            }
            Console.WriteLine("Amstrong of " + number + " is: " + amstr);
        }
        public static void demo2()
        {
            Class4 obj6 = new Class4();
            obj6.demo();

        }
    }
}
