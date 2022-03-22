using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution_48
    {
        void Main(string[] args)
        {
            double testcase = double.Parse(Console.ReadLine());
            double total = 0;
            for (double i = 0; i < testcase; i++)
            {
                double input = double.Parse(Console.ReadLine());
                total = input;

                for (double j = total; total > 0; j--)
                {
                    if (total <= 1)
                    {
                        break;
                    }
                    if (total % 2 == 0)
                    {
                        total = total / 2;
                    }
                    else
                    {
                        total = 3 * total + 1;
                    }
                }
                if (total == 1)
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
}
