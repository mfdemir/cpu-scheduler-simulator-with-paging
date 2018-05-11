using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduler_Simulator_With_Paging
{
    class StackElement
    {
        public int value;
        public StackElement next;
        public StackElement prev;
        public StackElement(int _value)
        {
            value = _value;
        }
    }
}
