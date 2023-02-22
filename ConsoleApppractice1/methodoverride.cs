using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
        class animal
        {
            public virtual void food()
            {
                Console.WriteLine("this mtd describes food for animal");
            }
        }
        class dog : animal
        {
            public override void food()
            {
                Console.WriteLine("food for cat");
            }
        }
    class lion : animal
    {
        public override void food()
        {
            Console.WriteLine("food for cat");
        }
    }
    internal class methodoverride
    {
    }
}
