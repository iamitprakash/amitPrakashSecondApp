using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyStockReportAutomation.Service
{
    public class Membership
    {
        public void membershipActivation(int id)
        {
            Console.WriteLine("\nMembership has been ACTIVATED for I'd " + id);
        }
        public void membershipUpgarde(int id)
        {
            Console.WriteLine("\nMembership has been UPGRADED for I'd " + id);
        }
    }
}