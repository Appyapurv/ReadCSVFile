using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution44
    {
        void Main(string[] args)
        {
            for (int n; (n = int.Parse(Console.ReadLine().Trim())) != 42;)
            {
                Console.WriteLine(n);
            }
        }
    }
}
