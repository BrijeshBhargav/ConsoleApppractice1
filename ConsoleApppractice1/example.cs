using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class example
    {

        public readonly int val1=5;

        public const int val = 5;
        public example()
        {
             val1 = 8;
            Console.WriteLine( "constructor" +val1);
        }
        
        public  void test()
        {
           int val = 6;
            Console.WriteLine("val"+val);
        }
        
        }
   
    }



