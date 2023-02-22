using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    partial class linked
    {
        public void test()
        {
            LinkedList<string> names = new LinkedList<string>();
            
            names.AddLast(" Jaiswal"); //end of list
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddFirst("Irfan"); //added to first index
            names.AddFirst("John");
            names.RemoveFirst(); // first index removed
            names.RemoveLast(); // last index removed
            names.Remove("Ankit");
            
            // names.Clear ();   used to clear all data
            names.AddFirst("John");
            names.AddFirst("John");

            foreach (var name in names)

            {
                Console.WriteLine(name);

            }
        }
    }
    partial class dict
    {
        public void test1()

        {
            var names = new Dictionary<string, string>();
            names.Add("1", "Sonoo");
            names.Add("2", "Peter");
            names.Add("3", "James");
            names.Add("4", "Ratan");
            names.Add("5", "Irfan");
            names.Remove("3");
            // names.Clear();
          
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
    partial class hash
    {
        public void test1()

        {
            HashSet<string> names = new HashSet<string>();
         //   var names = new HashSet<string>();
            names.Add("hi");
            names.Add("hello");
            names.Add("how r u");
            names.Add("welcome");
            names.Remove("hello");
           // names.Clear ();
            foreach (var item in names)
            {
                Console.WriteLine (item);
            }
        }

    }
}
    
    


