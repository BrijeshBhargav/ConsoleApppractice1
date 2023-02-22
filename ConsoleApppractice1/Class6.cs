using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class Class6
    {
        public void IntReverseArray()
        {
            int[] arr = { 15, 16, 17, 18 };
            //Original Array
            Console.WriteLine("Original Array= ");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            // Reverse Array
            Array.Reverse(arr);
            Console.WriteLine("Reversed Array= ");
            foreach (int j in arr)
            {
                Console.WriteLine(j);
            }
            
        }
        public void StringReverseArray()
        {
            string[] arr1 = { "Teja", "Anil", "Bhargav", "Durga" };
            Console.WriteLine("Original Array=");
            foreach (string k in arr1)
            {
                Console.WriteLine(k);
            }
            // Reverse Array
            Array.Reverse(arr1);
            Console.WriteLine("Reversed Array= ");
            foreach (string l in arr1)
            {
                Console.WriteLine(l);
            }
            Console.ReadLine();
        }
        public void fibnoic()
        {
            int a = 0, b = 1, c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            c = a + b;
            Console.WriteLine(c);
            for (int i = 0; i < c; i++)
            {
                if (c <= 50)
                {
                    a = b;
                    b = c;
                    c = a + b;
                    Console.WriteLine(c);
                }
            }
        }
        public static void Fab()
        {
            Class6 c = new Class6();
            c.fibnoic();
        }
    }
}


