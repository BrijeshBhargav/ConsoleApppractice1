using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
   
        class parentclass1
        {
            public virtual void Greetings(int x)
            {
                Console.WriteLine("parent Class Saying Hello!");
            }
        }
        class childClass :parentclass1 
        {
            public  override void  Greetings(int x)
            {
             
                Console.WriteLine("child Class Saying Hello!");
            }
        }
    internal class metoverride
    {

    }
}

