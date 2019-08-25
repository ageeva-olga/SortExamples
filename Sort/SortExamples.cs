using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class SortExamples
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
        public static int[] Copy(int[] source)
        {
            int[] array = new int[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                array[i] = source[i];
            }
            return array;
        }
        public void SortBenchmark()
        {
            var sortEx = new SortExamples();
            var source = sortEx.RandomArrayGenerator(5000);
            var sortAlgs = new ISort[] { new BubbleSort(), new MaxMinSort(), new QuickSort() };
            foreach(var sort in sortAlgs)
                RunSorting(sort, source);
        }
        private void RunSorting(ISort sort, int[] source)
        {
            var array = SortExamples.Copy(source);
            var sortEx = new SortExamples();
            var sortingResult = sortEx.SortingTime(sort, array);
            sortEx.PrintLn(sortingResult);
        }
        public SortingResult SortingTime(ISort sort, int[] source)
        {
            var timeBefore = DateTime.Now;
            var array = sort.Sort(source);
            var timeAfter = DateTime.Now;
            return new SortingResult((timeAfter - timeBefore).Milliseconds, array);
        }
        public void PrintLn(SortingResult result)
        {
            Print(result);
            Console.WriteLine("");
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
