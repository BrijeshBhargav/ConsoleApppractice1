using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void callingsum1(int a, int b);
public delegate void callingsubtract(int a, int b);
namespace ConsoleApppractice1
{


	class del
	{
		public static void sum(int a, int b)
		{
			Console.WriteLine("(100 + 40) = {0}", a + b);
		}


		public static void subtract(int a, int b)
		{
			Console.WriteLine("(100 - 60) = {0}", a - b);
		}

		internal class delegateex1
		{
			public static void test1()
			{
				callingsum1 obj1 = new callingsum1(del.sum);
				callingsubtract obj2 = new callingsubtract(del.subtract);


				obj1(100, 40);
				obj2(100, 60);


			}
		}
	}
}



        

    
   


