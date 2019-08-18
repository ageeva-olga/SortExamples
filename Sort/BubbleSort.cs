using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class BubbleSort
    {
        public int[] Sort(int[] source, bool orderAsc)
        {
            int[] array = new int[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                array[i] = source[i];
            }
            for (int j = 1; j < array.Length; j++)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (orderAsc == true)
                    {
                        if (array[i] < array[i - 1])
                        {
                            Swap(array, i);
                        }
                    }
                    else
                    {
                        if (array[i] > array[i - 1])
                        {
                            Swap(array, i);
                        }
                    }
                }
            }
            return array;
        }
        private void Swap(int[] source, int index)
        {
            int elem = source[index - 1];
            source[index - 1] = source[index];
            source[index] = elem;
        }
    }
}
