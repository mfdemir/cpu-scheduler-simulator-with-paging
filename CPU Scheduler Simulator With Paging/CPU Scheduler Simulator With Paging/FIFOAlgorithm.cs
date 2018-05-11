using CPU_Scheduler_Simulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduler_Simulator_With_Paging
{
    public class FIFOAlgorithm : PageReplacementAlgorithm
    {
        int currentTurnIndex = 0;
        public FIFOAlgorithm(int _workingSetSize,DataGridView _dataGrid,Label _labelTotal,Label _labelHit,Label _labelFault, Label _labelHitRatio)
        {
            dataGrid = _dataGrid;
            labelTotal = _labelTotal;
            labelHit = _labelHit;
            labelFault = _labelFault;
            labelHitRatio = _labelHitRatio;
            workingSet = new Dictionary<int, int>(_workingSetSize);

            dataGrid.Rows.Clear();//Clean Data Grid
            for (int i = 0;i<_workingSetSize;i++)
            {
                workingSet[i] = -1;

                int tempIndex = dataGrid.Rows.Add();
                dataGrid.Rows[tempIndex].Cells[0].Value = "-";//Fill data grid with '-'s.
            }

        }

        public override void DemandPage(List<int> _pageNums,int _step)
        {
            
            List<int> pageNumsToAddWorkingSet = new List<int>(_pageNums);
            List<int> workingSetHitCells = new List<int>();
            foreach (var i in workingSet)
            {
                foreach(int pageNum in _pageNums)
                {
                    if (pageNum == i.Value)
                    {
                        total++;
                        hit++;
                        pageNumsToAddWorkingSet.Remove(pageNum);
                        workingSetHitCells.Add(i.Key);
                        UpdateVisuals(i.Key, -1, _step);

                    }
                }

            }
            foreach (int pagenum in pageNumsToAddWorkingSet)
            {
                total++;
                while (workingSetHitCells.Contains(currentTurnIndex))
                {
                    if (currentTurnIndex == workingSet.Count - 1)
                        currentTurnIndex = 0;
                    else
                        currentTurnIndex++;
                }
                workingSet[currentTurnIndex] = pagenum;
                UpdateVisuals(-1, currentTurnIndex, _step);
                if (currentTurnIndex == workingSet.Count - 1)
                    currentTurnIndex = 0;
                else
                    currentTurnIndex++;
            }
            
            return;
        }
        public override void InitWorkingSet(int size)
        {
            currentTurnIndex = 0;
            total = 0;
            hit = 0;
            workingSet = new Dictionary<int, int>(size);

            dataGrid.Rows.Clear();//Clean Data Grid
            for (int i = 0; i < size; i++)
            {
                workingSet[i] = -1;

                int tempIndex = dataGrid.Rows.Add();
                dataGrid.Rows[tempIndex].Cells[0].Value = "-";//Fill data grid with '-'s.
            }
            UpdateVisuals(-1, -1, -1);
            dataGrid.ClearSelection();
        }
    }
}
