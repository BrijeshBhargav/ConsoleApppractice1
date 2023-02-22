using System;
using System.Linq;
using System.Collections.Generic;

internal class employee
{

    int emp_id;
    string Emp_Name;
    int Emp_Salary;
    string Emp_Department;  
  public static void test()
    {

        List<employee> emp = new List<employee>()
       {
        new employee{emp_id = 101, Emp_Name = "arjun",
                 Emp_Salary = 50000, Emp_Department = "ABC"},
        new  employee{emp_id = 102, Emp_Name = "bheem",
                 Emp_Salary = 65000, Emp_Department = "DEF"},
        new  employee{emp_id = 103, Emp_Name = "krishna",
                 Emp_Salary = 45000, Emp_Department = "ABC"},
       
        };

        foreach (employee item in emp)
        {
            Console.WriteLine(item.emp_id + item.Emp_Name 
                + item.Emp_Department + item.Emp_Salary  );
        }
    }
}
