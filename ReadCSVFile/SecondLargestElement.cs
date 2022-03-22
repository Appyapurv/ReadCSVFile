using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReadCSVFile
{
    class SecondLargestElement
    {
         void Main(String[] args)
        {
            //array
            int[] array = new int[] { 3, 2, 1, 5, 9, 4, 7, 6, 8 };
            int total = array.Length;
            int Min = int.MaxValue;
            int Min2 = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < Min)
                {
                    Min = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < Min2 && array[i] != Min)
                {
                    Min2 = array[i];
                }
            }

        }
    }
}
