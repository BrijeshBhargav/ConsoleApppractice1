using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class Class7
    {
        public int n= int.Parse(Console.ReadLine());
        public int[] arr;
        public void test()
        {
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public void test2()
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i]);
            }
        }
        public void test3()
        {
            for( int i = n-1; i>=0; i--)
            {
                Console.Write(arr[i]);
            }
        }

    }
}
