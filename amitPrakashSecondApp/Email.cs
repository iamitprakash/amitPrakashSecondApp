using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyStockReportAutomation.Service
{
    public class Email
    {
        public void sendEmial(int id)
        {
            Console.WriteLine("\nPayment has been received against I'd " + id + "\n Email Notification has been sent for Actiavtion/Upgradation");
        }
    }
}