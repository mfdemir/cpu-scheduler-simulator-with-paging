using CPU_Scheduler_Simulator_With_Paging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduler_Simulator
{

    public class RoundRobinScheduler : MultiLevelableScheduler
    {

        public int
            quantum;

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
            duration = 0;
            isEnded = false;
            foreach (var item in allProcesses)
            {
                item.remainingBurstTime = item.initialBurstTime;
                item.endStep = 0;
            }
        }
        public RoundRobinScheduler(string _name, int _quantum, List<Process> _processes)
        {
            name = _name;
            quantum = _quantum;
            List<Process> copyProcesses = new List<Process>();

            allProcesses = new List<Process>(copyProcesses);
            unStartedProcesses = new List<Process>(allProcesses);
            finishedProcesses = new List<Process>();
            processQueue = new Queue<Process>();
            currentProcess = null;
            duration = 0;
        }
        public override bool isQuantumUsed()
        {
            return duration >= quantum;
        }
        /// <summary>
        /// Simulates one time unit
        /// </summary>
        /// <param name="step">Step number as time unit</param>
        /// <returns>Current process</returns>
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
                    duration = 0;
                }

                else if (duration >= quantum)
                {
                    processQueue.Enqueue(currentProcess);
                    currentProcess = processQueue.Dequeue();
                    duration = 0;
                }
                currentProcess.remainingBurstTime -= 1;
                duration++;

            }
            return new StepResponse(currentProcess, false);

        }
        public override Process Step(MultiLevelFeedbackQueueScheduler sender)
        {
            processesToRemove = new List<Process>();
            foreach (Process process in sender.unStartedProcesses)
            {
                if (process.arrivalTime == sender.step)
                {

                    sender.queues[0].processQueue.Enqueue(process);

                    processesToRemove.Add(process);
                }
            }
            foreach (var process in processesToRemove)
            {
                sender.unStartedProcesses.Remove(process);
            }

            if (currentProcess != null)
            {

                if (currentProcess.remainingBurstTime <= 0)
                {
                    currentProcess.endStep = sender.step;
                    sender.finishedProcesses.Add(currentProcess);
                    currentProcess = null;
                    foreach (var sch in sender.queues)
                    {
                        if (sch.processQueue.Count > 0)
                        {
                            sender.currentQueue = sch;
                        }
                    }
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
                    duration = 0;
                }

                else if (duration >= quantum)
                {
                    processQueue.Enqueue(currentProcess);
                    currentProcess = processQueue.Dequeue();
                    duration = 0;
                }
                currentProcess.remainingBurstTime -= 1;
                duration++;

            }
            return currentProcess;

        }


    }


}
