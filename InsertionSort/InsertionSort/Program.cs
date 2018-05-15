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
            CocktailSort(unsortArray);
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

        private static void CocktailSort(int[] array)
        {
            bool didSwap = true;
            int lowerBound = 1;
            int upperBound = array.Length;
            while (didSwap == true)
            {

                didSwap = false;

                for (int i = lowerBound; i < upperBound; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        int cache = 0;
                        cache = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = cache;
                        didSwap = true;
                    }
                }
                upperBound = upperBound - 1;

                for (int i = upperBound - 1; i > lowerBound - 1; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        int cache = 0;
                        cache = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = cache;
                        didSwap = true;
                    }
                }
                lowerBound = lowerBound + 1;
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
