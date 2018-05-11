using CPU_Scheduler_Simulator_With_Paging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace CPU_Scheduler_Simulator
{

    public partial class MainForm : Form
    {
        enum SimulationMode
        {
            oneStep,
            complete,
            notSelected
        }
        SimulationMode simulationMode = SimulationMode.notSelected;

        SimulationManager simulationManager;

        List<Process> processes = new List<Process>();
        int
            processCount,
            maxBurstTime,
            maxArrivalTime,
            pageCount,
            workingSetSize;
        FIFOAlgorithm FIFO;
        LRUAlgorithm LRU;
        public MainForm()
        {
            InitializeComponent();
            FIFO = new FIFOAlgorithm(workingSetSize, WSFIFODataGrid, labelFIFOTotal, labelFIFOHit, labelFIFOFault, labelFIFOHitRatio);
            LRU = new LRUAlgorithm(workingSetSize, WSLRUDataGrid, labelLRUTotal, labelLRUHit, labelLRUFault, labelLRUHitRatio,LRUStackDataGrid);
            simulationManager = new SimulationManager();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            processesDataGrid.ClearSelection();
            stepsDataGrid.ClearSelection();
            WSFIFODataGrid.ClearSelection();
            WSLRUDataGrid.ClearSelection();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Did any process demand any pages in this step.</returns>
        private bool Step()
        {
            bool isPageDemanded = false;
            List<StepResponse> stepResponse = simulationManager.Step(ref isPageDemanded);

            int index = stepsDataGrid.Columns.Add(simulationManager.step.ToString(), simulationManager.step.ToString());
            stepsDataGrid.Columns[index].Width = 25;
            int i = 0;
            foreach (var resp in stepResponse)
            {
                if (resp != null && resp.process != null)
                {
                    processesDataGrid.Rows[resp.process.pid].Cells[2].Value = resp.process.initialBurstTime - resp.process.remainingBurstTime;

                    if (resp.isMLFQ)
                    {
                        i += resp.sender.counter;
                        stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Value = "P" + resp.process.pid;

                        stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Style.BackColor =
                            stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Style.SelectionBackColor = resp.process.color;
                    }
                    else
                    {
                        stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Value = "P" + resp.process.pid;

                        stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Style.BackColor =
                            stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Style.SelectionBackColor = resp.process.color;
                    }
                }
                else
                {
                    stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Value = "idle";

                    stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Style.BackColor =
                        stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Style.SelectionBackColor = Color.FromArgb(0, 0, 0);

                    stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Style.ForeColor =
                        stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Style.SelectionForeColor = Color.FromArgb(255, 255, 255);
                }
                i++;
            }
            return isPageDemanded || simulationManager.isSimEnded;
        }
        private void refreshDataGrids()
        {
            //Grantt Chart Grid Initialization
            stepsDataGrid.Columns.Clear();
            int index = stepsDataGrid.Columns.Add("0", "0");
            stepsDataGrid.Columns[index].Width = 25;
            stepsDataGrid.Rows.Clear();
            foreach (var sch in simulationManager.schedulers)
            {
                if (sch.GetType() == typeof(MultiLevelFeedbackQueueScheduler))
                {
                    foreach (var item in ((MultiLevelFeedbackQueueScheduler)sch).queues)
                    {
                        int tempIndex = stepsDataGrid.Rows.Add();
                        stepsDataGrid.Rows[tempIndex].HeaderCell.Value = item.name;
                    }
                }
                else
                {
                    int tempIndex = stepsDataGrid.Rows.Add();
                    stepsDataGrid.Rows[tempIndex].HeaderCell.Value = sch.name;
                }
            }
            stepsDataGrid.Refresh();
            stepsDataGrid.ClearSelection();

            //Processes Grid Initialization
            processesDataGrid.Rows.Clear();
            processesDataGrid.Refresh();
            foreach (Process process in processes)
            {
                string[] pages = new string[process.pagesNeeded.Count];
                while (processesDataGrid.Columns.Count < process.pagesNeeded.Count + 4)
                {
                    processesDataGrid.Columns.Add("a", "Page Need");
                }
                for (int i = 0; i < process.pagesNeeded.Count; i++)
                {
                    pages[i] = process.pagesNeeded[i].pageNum + "[" + process.pagesNeeded[i].startTimeOfNeed + "-" + process.pagesNeeded[i].endTimeOfNeed + "]";
                }

                index = processesDataGrid.Rows.Add("P" + process.pid.ToString(), process.initialBurstTime.ToString(), (process.initialBurstTime - process.remainingBurstTime).ToString(), process.arrivalTime.ToString());
                processesDataGrid.Rows[index].DefaultCellStyle.BackColor = process.color;
                for (int j = 0; j < pages.Length; j++)
                {
                    processesDataGrid.Rows[index].Cells[j + 4].Value = pages[j];
                }

                processesDataGrid.Refresh();
            }
            processesDataGrid.ClearSelection();

        }
        private void Generate(int processNum)
        {
            //Simulation Manager Initialization
            simulationManager.step = 0;
            simulationManager.maxBurstTime = maxBurstTime;
            simulationManager.maxArrivalTime = maxArrivalTime;
            simulationManager.pageCount = pageCount;
            simulationManager.workingSetSize = workingSetSize;
            simulationManager.ResetSchedulers();
            processes = simulationManager.Generate(processNum);

            //Page Replacement Algorithms Initialization
            FIFO.InitWorkingSet(workingSetSize);
            LRU.InitWorkingSet(workingSetSize);

            //Call Visual Data Grid Update
            refreshDataGrids();
        }


        private void buttonStep_Click(object sender, EventArgs e)
        {
            if (simulationMode != SimulationMode.oneStep)
            {
                refreshDataGrids();
                simulationMode = SimulationMode.oneStep;
            }
            Step();

        }

        private void buttonSetMLFQ_Click(object sender, EventArgs e)
        {
            AddMLFQForm pop = new AddMLFQForm();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                string name = "MLFQ-" + pop.queues[0].name + "-" + pop.queues[1].name + "-" + pop.queues[2].name;
                List<MultiLevelableScheduler> list = new List<MultiLevelableScheduler>();
                listBoxMLFQ.Items.Clear();
                for (int i = 0; i < 3; i++)
                {
                    list.Add(pop.queues[i]);
                    listBoxMLFQ.Items.Add(pop.queues[i].name);
                }
                Scheduler tempScheduler = new MultiLevelFeedbackQueueScheduler(name, list, FIFO, LRU);
                simulationManager.schedulers.Clear();
                simulationManager.schedulers.Add(tempScheduler);

            }
            else
            {
                //do nothing
            }
        }

        private void buttonStepUntilDemand_Click(object sender, EventArgs e)
        {
            while (!Step()) ;
            stepsDataGrid.FirstDisplayedScrollingColumnIndex = stepsDataGrid.Columns.Count - 1;
        }

        private void buttonSimulate_Click(object sender, EventArgs e)
        {

            if (simulationMode != SimulationMode.complete)
            {
                refreshDataGrids();
                simulationMode = SimulationMode.complete;
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //Check TextBoxes
            if (!int.TryParse(textBoxProcessCount.Text, out processCount) || processCount <= 0 || processCount > 5)
            {
                MessageBox.Show("Check process count textbox!");
                return;
            }
            if (!int.TryParse(textBoxMaxBurstTime.Text, out maxBurstTime) || maxBurstTime <= 0)
            {
                MessageBox.Show("Check max burst time textbox!");
                return;
            }
            if (!int.TryParse(textBoxMaxArrivalTime.Text, out maxArrivalTime) || maxArrivalTime < 0)
            {
                MessageBox.Show("Check max arrival time textbox!");
                return;
            }
            if (!int.TryParse(textBoxPageCount.Text, out pageCount) || pageCount < 1 || pageCount > 20)
            {
                MessageBox.Show("Check max page count textbox!");
                return;
            }
            if (!int.TryParse(textBoxWorkingSetSize.Text, out workingSetSize) || workingSetSize < 1 || workingSetSize > 8)
            {
                MessageBox.Show("Check working set size textbox!");
                return;
            }
            if (simulationManager.schedulers.Count == 0)
            {
                MessageBox.Show("There are no schedulers in MLFQ. Please add schedulers.");
                return;
            }
            toolStripProgressBar1.Maximum = processCount;
            toolStripProgressBar1.Step = 1;
            Generate(processCount);
            buttonSimulate.Enabled = buttonStep.Enabled = buttonStepUntilDemand.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }
    }
}
