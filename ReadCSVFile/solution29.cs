using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution29
    {
        void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testcases; i++)
            {
                int input = int.Parse(Console.ReadLine());
                var ss = input * 2;

                for (int j = 0; j < ss; j++)
                {
                    Console.Write("*");
                    for (int k = ss; k > 0; k--)
                    {
                        Console.Write("#");
                    }
                    ss--;
                    Console.Write("*");
                    Console.WriteLine();
                }
                Console.WriteLine();

            }
        }
    }
}
