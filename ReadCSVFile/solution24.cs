using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution24
    {
        void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());
            int liftA = 0;
            int liftb = 7;
            int input;

            StringBuilder output = new StringBuilder(testcase * 2);

            while (testcase > 0)
            {
                input = int.Parse(Console.ReadLine());
                if (Math.Abs(input - liftA) > Math.Abs(input - liftb))
                {
                    output.AppendLine("B");
                    liftb = input;
                }
                else
                {
                    output.AppendLine("A");
                    liftA = input;
                }
                testcase--;
            }
            Console.WriteLine(output.ToString());
        }
    }
}
