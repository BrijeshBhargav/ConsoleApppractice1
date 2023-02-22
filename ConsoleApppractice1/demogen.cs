using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    class Demogen<t1,t2>
    {
        public void add(t1 x, t2 y)
        {
            Console.WriteLine("addition" );
        }
        public void sub(t1 x, t2 y)
        { }
        public void mul(t1 x, t1 y)
        { }
    }
    internal class demogen
    {
        public static void test()
        {
            Demogen<int,string> obj1 = new Demogen<int,string>();
            obj1.add(12,"");
            obj1.sub(12,"Brijesh");

        }
    }
}
