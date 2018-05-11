using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduler_Simulator
{
    class EarliestDeadlineFirstScheduler:Scheduler
    {
        List<Process> WaitingProcesses = new List<Process>();
        bool decideNextProcess = false;
        int maxDeadline;
        public EarliestDeadlineFirstScheduler(string _name, List<Process> _processes, Color _graphColor,int _maxDeadline)
        {
            name = _name;
            List<Process> copyProcesses = new List<Process>();
            allProcesses = new List<Process>(copyProcesses);
            unStartedProcesses = new List<Process>(allProcesses);
            finishedProcesses = new List<Process>();
            currentProcess = null;
            graphColor = _graphColor;
            maxDeadline = _maxDeadline;
        }
        /// <summary>
        /// Constructor for Shortest Job First Algorithm
        /// </summary>
        /// <param name="_name">Name of the scheduler(Used in UI)</param>
        /// <param name="_processes">Processes that scheduler will schedule</param>
        /// <param name="_graphColor">Color of the line that will represent in mean turnaround time graph</param>
        /// <param name="_deadlineMultiplier"></param>
        public EarliestDeadlineFirstScheduler(string _name, List<Process> _processes, Color _graphColor)
        {
            name = _name;
            List<Process> copyProcesses = new List<Process>();
            allProcesses = new List<Process>(copyProcesses);
            unStartedProcesses = new List<Process>(allProcesses);
            finishedProcesses = new List<Process>();
            currentProcess = null;
            graphColor = _graphColor;
            maxDeadline = 1;
        }
        public override void Reset(List<Process> _processes)
        {
            Random random = new Random();
            List<Process> copyProcesses = new List<Process>();
            foreach (var item in _processes)
            {
                Process tempProcess = new Process(item);
                tempProcess.deadLine = tempProcess.arrivalTime + tempProcess.initialBurstTime + random.Next(0,maxDeadline);
                copyProcesses.Add(tempProcess);
            }
            allProcesses = new List<Process>(copyProcesses);
            unStartedProcesses = new List<Process>(allProcesses);
            finishedProcesses = new List<Process>();
            WaitingProcesses = new List<Process>();
            currentProcess = null;
            isEnded = false;
            foreach (var item in allProcesses)
            {
                item.remainingBurstTime = item.initialBurstTime;
                item.endStep = 0;
            }
        }
        public override StepResponse Step(int step)
        {
            processesToRemove = new List<Process>();
            foreach (Process process in unStartedProcesses)
            {
                if (process.arrivalTime == step)
                {
                    if (currentProcess == null)
                    {
                        currentProcess = process;
                    }
                    else
                    {
                        decideNextProcess = true;
                        WaitingProcesses.Add(process);
                    }
                    processesToRemove.Add(process);
                }
            }
            foreach (var process in processesToRemove)
            {
                unStartedProcesses.Remove(process);
            }
            if (currentProcess != null)
            {
                if (currentProcess.remainingBurstTime <= 0)
                {
                    currentProcess.endStep = step;
                    finishedProcesses.Add(currentProcess);
                    currentProcess = null;
                    if (WaitingProcesses.Count == 0)
                    {
                        currentProcess = null;
                        if (finishedProcesses.Count == allProcesses.Count)
                        {
                            isEnded = true;
                        }
                        return null;
                    }
                    else
                    {
                        decideNextProcess = true;
                    }
                }
                if(decideNextProcess)
                {
                    Process minDeadline = currentProcess;
                    foreach (var _process in WaitingProcesses)
                    {
                        if (minDeadline == null)
                            minDeadline = _process;
                        else
                        {
                            if (_process.deadLine < minDeadline.deadLine || (_process.deadLine == minDeadline.deadLine && _process.remainingBurstTime < minDeadline.remainingBurstTime))
                                minDeadline = _process;
                        }
                    }
                    if (minDeadline != currentProcess)
                    {
                        if (currentProcess != null)
                            WaitingProcesses.Add(currentProcess);
                        WaitingProcesses.Remove(minDeadline);
                        currentProcess = minDeadline;
                    }
                    decideNextProcess = false;
                }
                currentProcess.remainingBurstTime -= 1;
            }
            return new StepResponse( currentProcess,false);
        }

    }
}
