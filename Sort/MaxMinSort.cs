using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class MaxMinSort : ISort
    {
        public int[] Sort(int[] source)
        {
            int min = source.Length;
            int index = 0;
            for (int j = 0; j < source.Length; j++)
            {
                for (int i = j; i < source.Length; i++)
                {
                    if (min >= source[i])
                    {
                        min = source[i];
                        index = i;
                    }
                }
                int elem = source[j];
                source[j] = min;
                source[index] = elem;
                min = source.Length;
            }
            return source;
        }
    }
}
