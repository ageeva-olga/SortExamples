using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public  class BubbleSort : ISort
    {
        public int[] Sort(int[] source)
        {
            bool orderAsc = true;
            for (int j = 1; j < source.Length; j++)
            {
                for (int i = 1; i < source.Length; i++)
                {
                    if (orderAsc == true)
                    {
                        if (source[i] < source[i - 1])
                        {
                            Swap(source, i);
                        }
                    }
                    else
                    {
                        if (source[i] > source[i - 1])
                        {
                            Swap(source, i);
                        }
                    }
                }
            }
            return source;
        }
        private void Swap(int[] source, int index)
        {
            int elem = source[index - 1];
            source[index - 1] = source[index];
            source[index] = elem;
        }
    }
}
