using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
     partial class partialex
    {
        public  void demo1 ()
        {
            int a = 5, b = 10, c;
            c = a * b;
            Console.WriteLine("partial"+c);
        }
    
    }
    partial class partialex
    {
        public  void demo2()
        {
            int a = 4, b = 1, c;
            c = a + b;
            Console.WriteLine("partial add" + c);
        }
    }
     partial class partialex
        {

        }
    }

