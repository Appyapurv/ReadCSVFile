using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class Solution1
    {
        void Main(string[] args)
        {
            int[] array = new int[] { 1, 4, 3, 4, 5, 4, 5, 7, 8 };
            int[] outputArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;

                    }

                }
            }

            //for (int x = 0; x < array.Length / 2; x++)
            //{
            //    int swap = array[x];
            //    array[x] = array[array.Length - 1 - x];
            //    array[array.Length - 1 - x] = swap;
            //}


            int x = 0;
            int size = array.Length - 1;
            for (int k = 0; k < array.Length / 2; k++)
            {

                outputArray[x] = array[size - k];
                x++;
                outputArray[x] = array[k];
                x++;
                if (k == array.Length / 2 - 1 && array.Length % 2 != 0)
                {
                    k++;
                    outputArray[x] = array[size - k];
                    break;
                }
            }

        }
    }
}
