using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class SortingResult
    {
        public int Time;
        public int[] Array;
        public SortingResult(int time, int[] array)
        {
            Time = time;
            Array = array;
        }
    }
}
