using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution23
    {
         void Main(String[] args)
        {
            int testcases = int.Parse(Console.ReadLine());
            int liftA = 0;
            int liftB = 7;

            //3 5
            for (int i = 0; i < testcases; i++)
            {
                int input = int.Parse(Console.ReadLine());
                {
                    if (Math.Abs(input - liftA) > Math.Abs(input - liftB))
                    {
                        liftB = input;
                        Console.WriteLine("B");
                    }
                    else
                    {
                        liftA = input;
                        Console.WriteLine("A");
                    }
                }
            }
        }
    }
}
