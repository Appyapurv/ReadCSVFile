using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution43
    {
         void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int total = input * 10;

            for (int i = input; i <= total; i = i + input)
            {
                Console.WriteLine(input);
            }
        }
    }
}
