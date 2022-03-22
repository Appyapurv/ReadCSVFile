using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution15
    {
        void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numberArray = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numberArray[i] = int.Parse(input[i]);
            }
            //logic  
            int sum = 0;
            int l = numberArray[0]; //first value
            int r = numberArray[1];// last value
            int k = numberArray[2];// divisible by
            for (int i = l; i <= r; i++)
            {
                if (i % k == 0)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
