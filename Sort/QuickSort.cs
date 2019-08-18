using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class QuickSort
    {
        public int[] Sort(int[] source)
        {
            if (source.Length == 0)
                return source;

            var baseElem = source[source.Length / 2];
            var less = LessThenBase(source, baseElem);
            var more = MoreThenBase(source, baseElem);
            var newArray = QuickSort.Concatenate(Sort(less), new int[1] { baseElem }, Sort(more));
            return newArray;
        }

        public static int[] MoreThenBase(int[] source, int baseElem)
        {
            var array = new List<int>();
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] > baseElem)
                {
                    array.Add(source[i]);
                }
            }
            return array.ToArray();
        }
        public static int[] LessThenBase(int[] source, int baseElem)
        {
            var array = new List<int>();
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < baseElem)
                {
                    array.Add(source[i]);
                }
            }
            return array.ToArray();
        }
        public static int[] Concatenate(int[] source1, int[] source2, int[] source3)
        {
            var array = new int[source1.Length + source2.Length + source3.Length];
            for (int i = 0; i < source1.Length; i++)
            {
                array[i] = source1[i];
            }
            for (int i = source1.Length; i < source1.Length + source2.Length; i++)
            {
                array[i] = source2[i - source1.Length];
            }

            for (int i = source1.Length + source2.Length; i < source1.Length + source2.Length + source3.Length; i++)
            {
                array[i] = source3[i - source1.Length - source2.Length];
            }
            return array;
        }
    }
}
