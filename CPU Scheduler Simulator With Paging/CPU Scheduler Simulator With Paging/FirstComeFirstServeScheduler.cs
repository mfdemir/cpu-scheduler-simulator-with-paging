using CPU_Scheduler_Simulator_With_Paging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduler_Simulator
{
    class FirstComeFirstServeScheduler : MultiLevelableScheduler
    {

        public FirstComeFirstServeScheduler(string _name, List<Process> _processes)
        {
            name = _name;
            List<Process> copyProcesses = new List<Process>();
            allProcesses = new List<Process>(copyProcesses);
            unStartedProcesses = new List<Process>(allProcesses);
            finishedProcesses = new List<Process>();
            processQueue = new Queue<Process>();
            currentProcess = null;
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
            processQueue = new Queue<Process>();
            currentProcess = null;
            isEnded = false;
            foreach (var item in allProcesses)
            {
                item.remainingBurstTime = item.initialBurstTime;
                item.endStep = 0;
            }
        }
        public override bool isQuantumUsed()
        {
            return false;
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
                        processQueue.Enqueue(process);
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

                    if (processQueue.Count == 0)
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
                        currentProcess = processQueue.Dequeue();
                    }
                }
                currentProcess.remainingBurstTime -= 1;
            }
            return new StepResponse(currentProcess,false);
        }

        public override Process Step(MultiLevelFeedbackQueueScheduler sender)
        {
            if (currentProcess != null)
            {
                if (currentProcess.remainingBurstTime <= 0)
                {
                    currentProcess.endStep = sender.step;
                    finishedProcesses.Add(currentProcess);

                    if (processQueue.Count == 0)
                    {
                        currentProcess = null;
                        if (finishedProcesses.Count == allProcesses.Count)
                        {
                            isEnded = true;
                        }
                    }
                    else
                    {
                        currentProcess = processQueue.Dequeue();
                    }
                }
                if (currentProcess != null)
                    currentProcess.remainingBurstTime -= 1;
            }
            return currentProcess;
        }
    }
}
