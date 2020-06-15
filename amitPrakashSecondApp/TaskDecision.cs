using DailyStockReportAutomation.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyStockReportAutomation
{
    public class TaskDecision
    {
        /// <summary>
        /// Ojbect Creation
        /// </summary>
        Slip _Slip = new Slip();
        Membership _membership = new Membership();
        Email _Email = new Email();
        VideoModule _videoModule = new VideoModule();

        bool courtecision = true;
        public void taskDistribution(int[] taskdetails)
        {
            DailyStockdetails _dailyStockDetails = new DailyStockdetails();
            //  int[] taskdetails = _dailyStockDetails.dailyStockCalculation();

            for (int i = 0; i < taskdetails.Length; i++)
            {
                switch (taskdetails[i])
                {
                    case 0:
                        _Slip.packingSlipDetails(i);
                        break;
                    case 1:
                        _Slip.royalitySlip(i);
                        break;
                    case 2:
                        _membership.membershipActivation(i);
                        break;
                    case 3:
                        _membership.membershipUpgarde(i);
                        break;
                    case 4:
                        _Email.sendEmial(i);
                        break;
                    case 5:
                        _videoModule.SkiVideo(i, courtecision);
                        break;
                    case 6:
                        _Slip.agentSlip(i);
                        break;
                }
            }
        }
    }
}