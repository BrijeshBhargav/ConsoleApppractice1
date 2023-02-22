using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void callingadd(int x,int y);
public delegate int callingsum();
namespace ConsoleApppractice1
{
    class Delegate
    {
        public static void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static int sum()
        {
            Console.WriteLine("sub");
            return 0;
        }
        public static string nam()
        {
            Console.WriteLine ("name");
            return "";
        }
    }
    internal class delegate2
    {
        public static void test2()
        {
            Delegate.add(4,8);
            Delegate.sum();
            Delegate.nam();
        }

    }
}
