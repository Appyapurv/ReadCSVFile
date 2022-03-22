using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution6
    {
        void Main(string[] args)
        {
            //first largest value from array
            int[] array = new int[] { 1, 4, 5, 9, 3, 4, 6, 8, 3 };
            int Min = int.MinValue;
            int Max = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > Min)
                {
                    Min = array[i];
                }
                if (array[i] < Max)
                {
                    Max = array[i];
                }
            }

        }
    }
}
