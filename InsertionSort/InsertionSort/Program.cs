using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortArray = new int[5] { 12, 11, 15, 3, 7 };
            ShakerSort.Sort(unsortArray);
            Console.WriteLine(String.Join(", ", unsortArray));

       
        }




        private static void BubbleSort(int[] array)
        {
            bool didSwap = true;

            while (didSwap == true)
            {
                didSwap = false;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[i - 1])
                    {
                        int cache = 0;
                        cache = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = cache;
                        didSwap = true;
                    }



                }


            }

        }

        private static void QuickSort(int[] array)
        {

        }


















        private static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {

                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int cache = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = cache;
                    }
                    else break;
                }
            }
        }






    }
}
