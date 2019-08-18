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
        public SortingResult SortingTime(int[] source, bool orderAsc)
        {
            var timeBefore = DateTime.Now;
           // var array = BubbleSort(source, orderAsc);
            var timeAfter = DateTime.Now;
            return new SortingResult((timeAfter - timeBefore).Milliseconds, source);
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
