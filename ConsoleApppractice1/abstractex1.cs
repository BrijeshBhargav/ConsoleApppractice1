using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    abstract class Animal
    {

        public abstract void animalSound();
    
        public virtual void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
     class Dog : Animal
     {
        public override void animalSound()
        {
          Console.WriteLine("The pig says: bow");
        }
     }
   
}
        internal class abstractex1
        {

        }
    
