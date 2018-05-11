using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduler_Simulator
{
    class HighestResponseRatioNextScheduler :Scheduler
    {
        List<Process> WaitingProcesses = new List<Process>();
        public HighestResponseRatioNextScheduler(string _name, List<Process> _processes, Color _graphColor)
        {
            name = _name;
            List<Process> copyProcesses = new List<Process>();
            allProcesses = new List<Process>(copyProcesses);
            unStartedProcesses = new List<Process>(allProcesses);
            finishedProcesses = new List<Process>();
            currentProcess = null;
            graphColor = _graphColor;
        }
        public override void Reset(List<Process> _processes)
        {
            List<Process> copyProcesses = new List<Process>();
            foreach (var item in _processes)
            {
                copyProcesses.Add(new Process(item));
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
                        Process maxPriority = null;
                        foreach(var _process in WaitingProcesses)
                        {
                            _process.priority = (double)(_process.remainingBurstTime + step - _process.arrivalTime) /  _process.remainingBurstTime;
                            if (maxPriority == null)
                                maxPriority = _process;
                            else if 
                                (_process.priority > maxPriority.priority) maxPriority = _process;
                        }
                        WaitingProcesses.Remove(maxPriority);
                        currentProcess = maxPriority;
                    }
                }
                
                currentProcess.remainingBurstTime -= 1;
            }
            return new StepResponse( currentProcess,false);
        }

    }
}
