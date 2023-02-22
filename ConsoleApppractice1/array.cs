using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class array
    {
        public static void test()
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            for(int i = 1; i < 7; i++)
            {
                Console.WriteLine("for loop:"+x[i]);
            }
            foreach (int item in x)
            {
                Console.WriteLine("foreach"+item);
            }
            
            
            }
        }
    }

