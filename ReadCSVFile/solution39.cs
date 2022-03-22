using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution39
    {
        void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = input / 3;

            int sum1 = sum + sum + sum;
            if (input == sum1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
