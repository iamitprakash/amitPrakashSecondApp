using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DailyStockReportAutomation
{
    public class DailyStockdetails
    {
        Random random = new Random();

        public void dailyStockCalculation()
        {
            TaskDecision ts = new TaskDecision();

            int numberofDailydStock = random.Next(1, 100);

            int[] dailystockType = new int[numberofDailydStock];


            for (int i = 0; i < numberofDailydStock; i++)
            {
                dailystockType[i] = random.Next(0, 6);
            }
            Console.WriteLine("Task List for " + DateTime.Today.ToString());
            foreach (var item in dailystockType)
            {
                Console.Write(item + " ");
            }
            ts.taskDistribution(dailystockType);
        }
    }
}