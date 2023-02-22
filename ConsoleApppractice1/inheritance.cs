using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
   
    class inheritance
    {
        public int x, y, z;
        public void add()
        {
            x = 23; y = 22; z = x + y;
            Console.WriteLine("add is:" + z);
        }
    }
     class inheritance2
    {
        public int z;
        public static void sub()
        {
          
            Console.WriteLine("add is:");
        }
    }
    class childclass : inheritance
    {
        public void mul()
        {
            x = 4;
            Console.WriteLine("mil is:"+x);
        }
    }
    class childclass1 : inheritance2
    {
        public void div()
        {

            Console.WriteLine("mil is:"+z);
        }
    }
}

