using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    static class QuickSort
    {
        public static void Sort(int[] array)
        {
            //pivot bekommen
            Random random = new Random();
            int pivot = random.Next(array.Length);
            Console.WriteLine(pivot);

            int leftSide = array.Length - pivot;
            int rightSide = array.Length - leftSide;

        }
    }
}
