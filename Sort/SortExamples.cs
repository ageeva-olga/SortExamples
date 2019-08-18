using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class SortExamples
    {
       public int[] RandomArrayGenerator(int size)
        {
            var randomizer = new Random();
            int[] array = new int[size];
            for(int i=0; i<size; i++)
            {
                int index = randomizer.Next(0, size);
                while(array[index] != 0)
                {
                    index = randomizer.Next(0, size);
                }

                array[index] = i;

                //array[i] = randomizer.Next(0, size);
            }
            return array;
        }
        public int[] BubbleSort(int[] source, bool orderAsc)
        {
            int[] array = new int[source.Length];
            for(int i=0; i<source.Length; i++)
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
        public SortingResult SortingTime(int[] source, bool orderAsc)
        {
            var timeBefore = DateTime.Now;
            var array = BubbleSort(source, orderAsc);
            var timeAfter = DateTime.Now;
            return new SortingResult((timeAfter - timeBefore).Milliseconds, array);
        }
        public void Print(SortingResult result)
        {

            if(result.Array.Length<=20)
            {
                for(int i = 0; i<result.Array.Length; i++)
                {
                    PrintNumber(result.Array[i]);
                }
            }
            else
            {
                for( int i = 0; i<10; i++)
                {
                    PrintNumber(result.Array[i]);
                }
                Console.Write("... ");
                for(int i = result.Array.Length-10; i< result.Array.Length; i++)
                {
                    PrintNumber(result.Array[i]);
                }
            }
            Console.Write(string.Format("Time: {0} ms", result.Time));

     
        }
        private void PrintNumber(int number)
        {
            string formattedString = string.Format("{0} ", number);
            Console.Write(formattedString);
        }
    }
}
