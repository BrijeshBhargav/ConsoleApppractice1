using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class excep
    {
        public static void e1()
        {
            TryAgain:
            try
            {
                Console.WriteLine("enter x val");
                int x= Convert .ToInt32(Console.ReadLine());
                Console.WriteLine("enter y val");
                int y= Convert .ToInt32(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("div is :" + z);
            }
            catch (Exception ex)
            {
                Console.WriteLine("pls enter only int val" + ex.Message);
                goto TryAgain;
            }

        }
    }
}
