using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyStockReportAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            DailyStockdetails _dailyStockCalculation = new DailyStockdetails();
            _dailyStockCalculation.dailyStockCalculation();
            Console.ReadKey();
        }
    }
}