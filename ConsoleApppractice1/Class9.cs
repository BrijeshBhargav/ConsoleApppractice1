using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class Class9
    {
        public static void Factorialnumber()
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);


        }
    }
}

