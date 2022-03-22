using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution54
    {
        void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            int zCount = 0;
            int oCount = 0;

            foreach (char c in input)
            {
                if (c == 'Z' || c == 'z')
                {
                    zCount = zCount + 1;
                }
                if (c == 'O' || c == 'o')
                {
                    oCount = oCount + 1;
                }
            }
            if (zCount * 2 == oCount)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
