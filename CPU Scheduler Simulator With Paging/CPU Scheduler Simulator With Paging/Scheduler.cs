using CPU_Scheduler_Simulator_With_Paging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduler_Simulator
{
    public abstract class Scheduler
    {
        public string name = "noname";
        public bool isEnded = false;

        public Color graphColor = Color.Black;
        public List<Process> allProcesses = null;
        public List<Process> unStartedProcesses = null;
        public List<Process> processesToRemove = null;
        public List<Process> finishedProcesses = null;

        public Process currentProcess = null;
        public abstract StepResponse Step(int step);
        public abstract void Reset(List<Process> _processes);
    }
    public class StepResponse
    {
        public Process process;
        public bool isMLFQ;
        public bool isPageDemanded = false;
        public bool isEnded = false;
        public MultiLevelFeedbackQueueScheduler sender;
        public StepResponse(Process _process, bool _isMLFQ)
        {
            process = _process;
            isMLFQ = _isMLFQ;
        }
        public StepResponse(Process _process, bool _isMLFQ,MultiLevelFeedbackQueueScheduler _sender)
        {
            process = _process;
            isMLFQ = _isMLFQ;
            sender = _sender;
        }
        public StepResponse(Process _process, bool _isMLFQ, MultiLevelFeedbackQueueScheduler _sender,bool _isPageDemanded,bool _isEnded)
        {
            process = _process;
            isMLFQ = _isMLFQ;
            sender = _sender;
            isPageDemanded = _isPageDemanded;
            isEnded = _isEnded;
        }
    }
}
