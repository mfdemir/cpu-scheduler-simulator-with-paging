using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduler_Simulator_With_Paging
{
    public class LRUAlgorithm : PageReplacementAlgorithm
    {
        IntStack stack = new IntStack();
        DataGridView stackDataGrid;
        public LRUAlgorithm(int _workingSetSize, DataGridView _dataGrid, Label _labelTotal, Label _labelHit, Label _labelFault, Label _labelHitRatio,DataGridView _stackDataGrid)
        {
            dataGrid = _dataGrid;
            stackDataGrid = _stackDataGrid;
            labelTotal = _labelTotal;
            labelHit = _labelHit;
            labelFault = _labelFault;
            labelHitRatio = _labelHitRatio;
            workingSet = new Dictionary<int, int>(_workingSetSize);

            dataGrid.Rows.Clear();//Clean Data Grid
            for (int i = 0; i < _workingSetSize; i++)
            {
                workingSet[i] = -1;

                int tempIndex = dataGrid.Rows.Add();
                dataGrid.Rows[tempIndex].Cells[0].Value = "-";//Fill data grid with '-'s.
            }
        }
        public override void DemandPage(List<int> _pageNums, int _step)
        {
            List<int> pageNumsToAddWorkingSet = new List<int>(_pageNums);
            List<int> workingSetHitCells = new List<int>();
            //If hits
            foreach (var i in workingSet)
            {
                foreach (int pageNum in _pageNums)
                    if (pageNum == i.Value)
                    {
                        total++;
                        hit++;
                        stack.Push(pageNum,stackDataGrid);
                        pageNumsToAddWorkingSet.Remove(pageNum);
                        workingSetHitCells.Add(i.Key);
                        UpdateVisuals(i.Key, -1, _step);

                    }
            }
            //If page not found in working set
            foreach (int pageNum in pageNumsToAddWorkingSet)
            {
                total++;
                //is working set full??

                int foundEmptyIndex = TryToFindEmptyCellInWorkingSet();

                if (foundEmptyIndex!=-1)
                {
                    workingSet[foundEmptyIndex] = pageNum;
                    stack.Push(pageNum,stackDataGrid);
                    UpdateVisuals(-1, foundEmptyIndex, _step);
                }
                else
                {
                    int lowestPage = stack.FindLowestPage(workingSet);
                    if (lowestPage == -1)
                    {
                        bool isThereAnyProblem = true;
                        foreach(var i in workingSet)
                        {
                            if(i.Value == -1)
                            {
                                workingSet[i.Key] = pageNum;
                                UpdateVisuals(-1, i.Key, _step);
                                stack.Push(pageNum,stackDataGrid);
                                isThereAnyProblem = false;
                                break;
                            }
                        }
                        if (isThereAnyProblem) MessageBox.Show("wut");

                    }
                    else
                    {
                        int lowestPageIndex = FindIndexOf(lowestPage);
                        workingSet[lowestPageIndex] = pageNum;
                        stack.Push(pageNum,stackDataGrid);
                        UpdateVisuals(-1, lowestPageIndex, _step);
                    }
                }
            }
        }
        public override void InitWorkingSet(int size)
        {
            stack = new IntStack();
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

        private int FindIndexOf(int pageNum)
        {
            for (int i = 0; i < workingSet.Count; i++)
            {
                if (pageNum == workingSet[i])
                {
                    return i;
                }
            }
            return -1;
        }
        private int TryToFindEmptyCellInWorkingSet()
        {
            
            for(int i=0;i<workingSet.Count;i++)
            {
                if (workingSet[i] == -1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
