using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class interfacesegeration
    {
    }
    public interface Ireport
    {
        bool AddReportDetails();
    }

    public interface IReportDatabase
    {
        bool  AddReportDetails();
        bool showReportDetails(int reportid);
    }

    public interface IAddReport
    {
        bool AddReportDetails();
    }
    public interface IGetReport
    {
        bool AddReportDetails();
    }
}
