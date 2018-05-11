using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduler_Simulator_With_Paging
{
    public class PageNeeded
    {
        public int
            pageNum,
            startTimeOfNeed,
            endTimeOfNeed;
        public PageNeeded(int _pageNum, int _startTimeOfNeed, int _endTimeOfNeed)
        {
            pageNum = _pageNum;
            startTimeOfNeed = _startTimeOfNeed;
            endTimeOfNeed = _endTimeOfNeed;
        }

    }
}
