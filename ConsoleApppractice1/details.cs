using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{

      class FixityData
        {
            public int Eid;
            public string Name;
            public string Email;
            public int Salary;
            public string Dept;
        }
   internal class details
       {
            public static void Data1()
            {
                HashSet <FixityData> obj = new HashSet<FixityData>()
            {
            new FixityData{ Eid=1,Name="Raj",Email="Raj@yahoo.com",Salary=1000,Dept="IT"},
            new FixityData{ Eid=2,Name="anu",Email="anu@yahoo.com",Salary=2000,Dept="HR"},
            new FixityData{ Eid=3,Name="khan",Email="khan@yahoo.com",Salary=30000,Dept="Sales"}
            };
                 

            
               
            Console.WriteLine("Eid    Name   Email");
                foreach (var item in obj )
                {
                    Console.WriteLine(item.Eid  + item.Name + item.Email );
                }
            }
        }
}
    
    

