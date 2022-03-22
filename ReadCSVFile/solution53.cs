using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution53
    {
        void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int total = input;
            int count = 0;

            for (int i = 1; total > 0; i++)
            {
                if (total >= 5)
                {
                    total = total - 5;
                    count++;
                }
                else if (total >= 4)
                {
                    total = total - 4;
                    count++;
                }
                else if (total >= 3)
                {
                    total = total - 3;
                    count++;
                }
                else if (total >= 2)
                {
                    total = total - 2;
                    count++;
                }
                else if (total >= 1)
                {
                    total = total - 1;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
