using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution38
    {
        void Main(string[] args)
        {
            string input = Console.ReadLine();
            input.ToCharArray();
            int[] ss = new int[input.Length];
            int sum = 0;
            int j = 1;
            for (int i = 0; i < input.Length; i++)
            {
                ss[i] = input[i];
                sum += ss[i] * j;
                j++;
            }
            if (sum % 11 == 0)
            {
                Console.WriteLine("Legal ISBN");
            }
            else
            {
                Console.WriteLine("Illegal ISBN");
            }

        }
    }
}
