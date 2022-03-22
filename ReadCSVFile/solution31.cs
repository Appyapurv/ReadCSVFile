using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution31
    {
        void Main(string[] args)
        {
            int noOfTestcases = int.Parse(Console.ReadLine());
            long result, time;
            var output = new StringBuilder();

            for (int i = 0; i < noOfTestcases; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                var a = int.Parse(arr[0]);
                var b = int.Parse(arr[1]);
                var c = int.Parse(arr[2]);

                result = a - 2 * b + c;
                if (result < 0)
                {
                    result += -1;
                }
                time = result / 2;
                time += result % 2;

                output.AppendLine(time.ToString());
            }
            Console.WriteLine(output.ToString());
        }
    }
}
