using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution46
    {
        void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum = sum + (((int)input[i]) - 96);
            }
            Console.WriteLine(sum);
        }
    }
}
