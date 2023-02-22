using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    interface x1
    {
         void add();
       
    }
    interface x2
    {
        void sub();

    }
     class interfaceex : x1,x2
    {
        public void add()
        {
            int a = 5, b = 7, c;
            c = a + b;
            Console.WriteLine(c);
        }
        public void sub()
        {
            int a = 5, b = 7, c;
            c = a - b;
            Console.WriteLine(c);

        }
        public void sub2()
        {
            int a = 5, b = 7, c;
            c = a - b;
            Console.WriteLine(c);

        }
    }
}
