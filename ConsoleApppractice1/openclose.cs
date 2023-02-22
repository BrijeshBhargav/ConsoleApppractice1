using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class openclose
    {
        public string ReportType { get; set; }
        public void GenerateReport()
        {
            if (ReportType == "stockinformatio")
            {
                //stock information rep
            }
            if (ReportType == "productinformation")
            {
                //product information
            }
        }
    }
    public class ReportGenerator
    {
        public virtual void GenerateReport()
        {
            // takes emp classand based on 
        }
    }
    public class stockinformation : ReportGenerator
    {
        public override void GenerateReport()
        {
            // generate stockinfo report
        }
    }
    public class Productinformation : ReportGenerator
    {
        public override void GenerateReport()
        {
            // generate productinfo report
        }
        public class skuinformation : ReportGenerator
        {
            public override void GenerateReport()
            {
                // generate productinfo report
            }
        }
    }
}