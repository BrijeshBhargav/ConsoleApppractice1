using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class Conv
    {
        static void main(string[] args)
        {
            int c = 10;
            string name = "brijesh bhargav";
            Console.WriteLine(c);
            Console.WriteLine(name);

            Console.WriteLine("enter val");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("int value is " + num);

            Console.WriteLine("enter int val");
            int int_ = int.Parse(Console.ReadLine());
            Console.WriteLine("int val is " + int_);

            Console.WriteLine("enter name");
            string namee = Console.ReadLine();
            Console.WriteLine(" my name is " + namee);


            float val_ = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("float val is" + val_);

            Console.WriteLine("enter byte val");
            Byte num_ = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("enter true or false");
            Boolean bool_ = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("it is" + bool_);


        }
    }
}
