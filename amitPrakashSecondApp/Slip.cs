using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyStockReportAutomation.Service
{
    public class Slip
    {
        public void packingSlipDetails(int id)
        {
            Console.WriteLine("\nPacking slip has been Generated for Task i'd" + id);
        }
        public void royalitySlip(int id)
        {
            Console.WriteLine("\nRoyality Slip has been generated for" + id);
        }
        public void agentSlip(int id)
        {
            Console.WriteLine("\nAgent Slip has been generated for" + id);
        }
    }
}