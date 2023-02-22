using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class staticconstr
    {
        public staticconstr(int a, int b)
        {

            int c = a - b;
            Console.WriteLine("result is" + c);
        }
        //static constructor must be only 1
        // and it must be parameterless
        // no need to create an object it calls directly
        static staticconstr()
        {
            int a = 1, b = 52, c;
            c = a + b;
            Console.WriteLine("add result is" + c);
        }
        

            
        
    }
}
