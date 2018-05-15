using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    static class ShakerSort
    {
        public static void Sort(int[] array)
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

    }
}
