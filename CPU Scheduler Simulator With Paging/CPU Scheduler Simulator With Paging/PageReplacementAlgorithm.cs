using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduler_Simulator_With_Paging
{
    public abstract class PageReplacementAlgorithm
    {
        protected DataGridView dataGrid;

        protected Label
            labelTotal,
            labelHit,
            labelFault,
            labelHitRatio;

        protected Dictionary<int, int> workingSet;

        protected int
            total = 0,
            hit = 0;

        public abstract void DemandPage(List<int> _pageNum, int _step);

        protected void UpdateVisuals(int hitIndex, int faultIndex, int step)
        {
            //Color Reset
            for (int i = 0; i < workingSet.Count; i++)
            {
                if (dataGrid.Rows[i].Cells[1].Value != null && (int)dataGrid.Rows[i].Cells[1].Value != step)
                    dataGrid.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.White;
            }
            //Set New Colors
            if (hitIndex != -1)
            {
                dataGrid.Rows[hitIndex].Cells[0].Style.BackColor = System.Drawing.Color.Green;
                dataGrid.Rows[hitIndex].Cells[1].Value = step;
            }
            if (faultIndex != -1)
            {
                dataGrid.Rows[faultIndex].Cells[0].Style.BackColor = System.Drawing.Color.Red;
                dataGrid.Rows[faultIndex].Cells[1].Value = step;
            }

            //Update Labels
            labelTotal.Text = "Total: " + total.ToString();
            labelHit.Text = "Hit: " + hit.ToString();
            labelFault.Text = "Fault: " + (total - hit).ToString();
            labelHitRatio.Text = "HitRatio: " + ((double)hit / total).ToString("P2");
            //Update Cell Data
            for (int i = 0; i < workingSet.Count; i++)
            {
                dataGrid.Rows[i].Cells[0].Value = workingSet[i] == -1 ? "-" : workingSet[i].ToString();
            }
        }

        public abstract void InitWorkingSet(int size);

    }
}
