using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class Class2
    {
        public static void Test()
        {
            int a;
            Console.WriteLine("enter a num");
             a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("given num is even");
            }
            else
            {
                Console.WriteLine("given num is odd");
            }
        }
        public static void anil()
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            int i, temp = (n / 2), k;
            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i >= 1 && j == 1 || i >= 1 && j == n || i == (n / 2) && j >= 1)
                    {
                        Console.Write("h" + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                for (int j = 1; j <= n; j++)
                {
                    if (i >= 1 && j == 1 || i >= 1 && j == n || i == (n / 2) && j >= 1 || i == 1 && j >= 1)
                    {
                        Console.Write("a" + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                for (k = 1; k <= n; k++)
                {
                    if (i >= 1 && k == 1 || i == 1 && k > 3 || i == 2 && k == 2)
                    {
                        if (k == n)
                        {
                            Console.Write("  ");
                        }
                        else
                        {
                            Console.Write("r" + " ");
                        }
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                for (k = 2; k <= n; k++)
                {
                    if (i >= 1 && k == temp)
                    {
                        Console.Write("i" + " ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                for (k = 1; k <= n; k++)
                {
                    if (i >= 1 && k == temp || i == 1 && k >= 1)
                    {
                        Console.Write("t" + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                for (int j = 1; j <= n; j++)
                {
                    if (i >= 1 && j == 1 || i >= 1 && j == n || i == (n / 2) && j >= 1)
                    {
                        Console.Write("h" + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                for (int j = 1; j <= n; j++)
                {
                    if (i >= 1 && j == 1 || i >= 1 && j == n || i == (n / 2) && j >= 1 || i == 1 && j >= 1)
                    {
                        Console.Write("a" + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
