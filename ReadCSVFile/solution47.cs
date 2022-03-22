using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution47
    {
        void Main(String[] args)
        {
            int testcases = int.Parse(Console.ReadLine());
            int sum = 0;

            string[] inputA = Console.ReadLine().Split(' ');
            string[] inputB = Console.ReadLine().Split(' ');

            for (int i = 0; i < testcases; i++)
            {
                sum += int.Parse(inputA[i]) - int.Parse(inputB[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
