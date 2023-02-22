using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class sum
    {
        public static void test()
        {
            int sum;
            Console.WriteLine("Calculate the sum of two numbers:");
            Console.WriteLine("Input number1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input number2:");
           int num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("Result:" + sum);

            Console.ReadKey();
        }
        public static  void test1()
        {
            string sentence;
            Console.Write("Enter String  : ");
            sentence = Console.ReadLine();
            string[] letters = sentence.Split(' ');
            Console.WriteLine("Count of letters :" + letters.Length);
            Console.ReadKey();
        }
    }
}

