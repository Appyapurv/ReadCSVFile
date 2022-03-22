using System;
using System.Collections.Generic;
using System.Text;

namespace DataStuture
{
    class solution2
    {
        void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] array = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = sizeOfArray - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
