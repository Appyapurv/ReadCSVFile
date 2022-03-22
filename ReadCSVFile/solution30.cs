using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution30
    {
        void Main(String[] args)
        {
            int testcase = Int16.Parse(Console.ReadLine());
            int data = 0;

            for (int i = 0; i < testcase; i++)
            {
                data = Int16.Parse(Console.ReadLine());
                for (int j = 0; j < data; j++)
                {
                    for (int k = 0; k <= j; k++)
                    {
                        Console.Write("*");
                    }
                    for (int k = 0; k < (data - (j + 1)); k++)
                    {
                        Console.Write("##");
                    }
                    for (int k = 0; k <= j; k++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(Environment.NewLine);
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
