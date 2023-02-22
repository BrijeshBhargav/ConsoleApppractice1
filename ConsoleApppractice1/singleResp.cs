using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    internal class singleResp
    {
        
        public bool AddNewEmployee(Employee em)
        {
            return true;
        }
        //public void GenerateEmployeeReport(Employee em)
        // {
        //return report data
        // }
    }
    public class ReportGeneration
    {
        public void GenerateReport(Employee em)
        {
         // report with employee data
        }
    }
    }

