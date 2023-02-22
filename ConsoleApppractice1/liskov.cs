using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class liskov
    {
    }
    public abstract class Report
    {
        public virtual string Getstockinfo(int reportid)
        {
            return "stock inf details";
        }
        public virtual string Getproductinfo(int reportid)
        {
            return "product inf details";
        }
    }
    public class Stockinformation : Report
    {
        public override string Getstockinfo(int reportid)
        {
            return "stockinformation";
        }
        public override string Getproductinfo(int reportid)
        {
            return "productinformation";
        }
        public class prodictinformation : Report
        {
            public interface Istockinformation
            {
                string Getstockinfo(int reportid);
            }
            /*  public override string Getstockinfo(int reportid)
              {
                  return "stockinformation";
              }
              public override string Getproductinfo(int reportid)
              {
                  return "productinformation";*/
        }
        }

    


    public interface Istockinformation
    {
        string Getstockinfo(int reportid);
    }
    public interface Iproductinformation
    {
        string Getproductinfo(int reportid);
    }
}
