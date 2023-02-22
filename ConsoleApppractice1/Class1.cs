using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class Class1
    {  
       public static void floating()
        {
            float m; 
            Console.WriteLine("enter num1 val");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter num2 val");
            float num2 = Convert.ToSingle(Console.ReadLine()); 

            m= num1* num2;
            Console.WriteLine("result is " + m);

        }

    }
}
