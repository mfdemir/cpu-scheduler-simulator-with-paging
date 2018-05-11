using CPU_Scheduler_Simulator_With_Paging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduler_Simulator
{
    public class SimulationManager
    {
        public int i;
        public bool isSimEnded
        {
            get
            {
                foreach (var item in schedulers)
                {
                    if (item.isEnded) return true;
                }
                return false;
            }
        }
        Random random = new Random();
        public List<Process> processes;
        public int
            maxArrivalTime = 25,
            maxBurstTime = 25,
            minPeriod = 25,
            maxPeriod = 100,
            period,
            quantum,
            totalBurstTime = 0,
            step = 0,
            pageCount,
            processCount,
            workingSetSize;

        public List<Scheduler> schedulers = new List<Scheduler>();
        public List<Process> Generate(int count)
        {
            processCount = count;
            random = new Random();
            int arrivalTime, burstTime;
            processes = new List<Process>();

            for (int i = 0; i < processCount; i++)
            {
                arrivalTime = random.Next(maxArrivalTime);
                burstTime = random.Next(1, maxBurstTime);

                Color color = Color.FromArgb(random.Next(64, 256), random.Next(64, 256), random.Next(64, 256));
                if (totalBurstTime < arrivalTime + burstTime) totalBurstTime = arrivalTime + burstTime;



                processes.Add(new Process(i, arrivalTime, burstTime, 0, color, GeneratePagesNeeded(burstTime)));
            }

            ResetSchedulers();
            return processes;
        }
        public void ResetSchedulers()
        {
            if (processes != null)
            {
                foreach (var sch in schedulers)
                {
                    sch.Reset(processes);
                }
            }
        }
        public Dictionary<Scheduler, double[]> MeanTurnaroundTime(int _count, BackgroundWorker bgw)
        {
            Dictionary<Scheduler, double[]> meanTurnaround = new Dictionary<Scheduler, double[]>();
            foreach (var sch in schedulers)
            {
                meanTurnaround.Add(sch, new double[_count]);
            }

            for (i = 1; i <= _count; i++)
            {
                List<Process> a = new List<Process>(processes.GetRange(0, i));
                foreach (var sch in schedulers)
                {
                    sch.Reset(a);
                }


                while (!isSimEnded)
                {
                    foreach (var sch in schedulers)
                    {
                        sch.Step(step);
                    }
                    step++;
                }

                foreach (var sch in schedulers)
                {
                    foreach (Process p in sch.finishedProcesses)
                    {
                        meanTurnaround[sch][i - 1] += p.endStep - p.arrivalTime;
                    }
                    meanTurnaround[sch][i - 1] /= sch.finishedProcesses.Count;
                }

                step = 0;
                bgw.ReportProgress(i);
            }
            return meanTurnaround;

        }
        public List<StepResponse> Step(ref bool demandPage)
        {
            List<StepResponse> responses = new List<StepResponse>();
            foreach (var _scheduler in schedulers)
            {
                StepResponse tempStepResponse = _scheduler.Step(step);

                responses.Add(tempStepResponse);

                if (tempStepResponse != null && tempStepResponse.isPageDemanded)
                    demandPage = true;
            }
            step++;
            return responses;
        }

        List<PageNeeded> GeneratePagesNeeded(int burstTime)
        {

            int neededPageCount = random.Next(1, pageCount);//needed page count for every process

            List<PageNeeded> neededPages = new List<PageNeeded>();//The list that will be attached to process

            int splitBurstTime = random.Next(0, burstTime - 1);//Split burst time into 2 to make two different page group demands

            List<int> pageNums = new List<int>();//List that contains page numbers to assign, thus a process can not need same page number multiple times.

            //Fill this list with numbers
            for (int j = 0; j < pageCount; j++)
            {
                pageNums.Add(j);
            }
            int splitCount =RoundUpDivision(neededPageCount,workingSetSize);
            for(int i = 0;i<splitCount;i++)
            {

                int startTime = i * RoundUpDivision(burstTime,splitCount);
                int endTime = i == splitCount-1 ? burstTime -1 : (i+1) * RoundUpDivision(burstTime, splitCount) - 1;

                int remainingPagesNeededToFillAllSplits = i == splitCount -1 ? (neededPageCount % workingSetSize == 0 ? workingSetSize : neededPageCount % workingSetSize) : workingSetSize;
                for(int j = 0;j< remainingPagesNeededToFillAllSplits;j++)
                {
                    int randomInt = random.Next(0, pageNums.Count);
                    int tempPageNum = pageNums[randomInt];
                    pageNums.RemoveAt(randomInt);
                    neededPages.Add(new PageNeeded(tempPageNum, startTime, endTime));
                }
            }

            return neededPages;
        }
        private int RoundUpDivision(int a,int b)
        {
            return (a - 1) / b + 1;
        }
        

    }

}
