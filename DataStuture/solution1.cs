using System;
using System.Collections.Generic;
using System.Text;

namespace DataStuture
{
    class Solution1
    {
        void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"output:{array[i]}");
            }
            Console.WriteLine("*");
            // reverse 

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"output:{array[i]}");
            }
        }
    }
}
