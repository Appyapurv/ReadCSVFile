using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution45
    {
        void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            StringBuilder output = new StringBuilder();

            output.AppendLine("*   *");
            for (int i = 0; i < input; i++)
            {

                output.AppendLine("*   *");
                output.AppendLine("*****");
                output.AppendLine("*   *");
            }

            output.AppendLine("*   *");
            Console.WriteLine(output);
        }
    }
}
