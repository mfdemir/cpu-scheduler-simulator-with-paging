using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduler_Simulator_With_Paging
{
    public class IntStack
    {
        StackElement bottom, top;

        public void Push(int value,DataGridView grid)
        {
            StackElement newElement = new StackElement(value);
            if (bottom == null)
            {
                bottom = top = newElement;
            }
            else
            {
                StackElement currentElement = bottom;
                while (true)
                {
                    if (currentElement.value == value)
                    {
                        if (currentElement == bottom && currentElement == top)
                        {
                            PrintValues();
                            return;

                        }
                        else if (currentElement == bottom)
                        {
                            bottom = bottom.next;
                            bottom.prev = null;
                            top.next = currentElement;
                            currentElement.prev = top;
                            top = currentElement;
                            currentElement.next = null;
                            PrintValues();
                            return;
                        }
                        else if (currentElement == top)
                        {
                            PrintValues();
                            return;
                        }
                        else
                        {
                            currentElement.prev.next = currentElement.next;
                            currentElement.next.prev = currentElement.prev;
                            top.next = currentElement;
                            currentElement.prev = top;
                            top = currentElement;
                            currentElement.next = null;
                            PrintValues();
                            return;
                        }
                    }
                    if (currentElement.next == null)
                    {
                        break;
                    }
                    else
                    {
                        currentElement = currentElement.next;
                    }
                }
                top.next = newElement;
                newElement.prev = top;
                top = newElement;
                newElement.next = null;
                PrintValues();
                PrintStackToGridView(grid);
            }
        }
        void PrintValues()
        {

        }
        public int Peek()
        {
            return top.value;
        }
        public int Pop()
        {
            int i = top.value;
            top = top.prev;
            return i;
        }
        public int GetFirst()
        {
            if (bottom == null)
                return 0;
            else
                return bottom.value;
        }
        public bool IsEmpty()
        {
            return bottom == null;
        }
        public int FindLowestPage(Dictionary<int,int> items)
        {
            StackElement currentElement = top;
            int lowestPage = -1;
            while (currentElement != null)
            {
                if (items.Values.Contains(currentElement.value))
                {
                    lowestPage = currentElement.value;
                }
                currentElement = currentElement.prev;
            }
            return lowestPage;
        }
        private void PrintStackToGridView(DataGridView grid)
        {
            grid.Rows.Clear();

            StackElement currentElement = top;
            while(currentElement != null)
            {
                grid.Rows.Add(currentElement.value.ToString());
                currentElement = currentElement.prev;
            }
        }
    }
}
