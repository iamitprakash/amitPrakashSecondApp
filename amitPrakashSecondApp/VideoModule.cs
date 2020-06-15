using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyStockReportAutomation.Service
{
    public class VideoModule
    {

        public void SkiVideo(int id, bool decision)
        {
            Console.WriteLine("\nYour SKI Learning vidoe is here");
            if (decision)
            {
                firstAidVideo();
            }
        }

        public void firstAidVideo()
        {
            Console.WriteLine("\nAp per cout decision 1997 your FIRST AID video is released");
        }

    }
}