using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution35
    {
        void Main(String[] args)
        {
            string s = Console.ReadLine();
            char[] c = new char[s.Length];

            int m = 0;
            if (c[2] >= 'A' && c[2] <= 'Z' && c[2] != 'A' && c[2] != 'E' && c[2] != 'I' && c[2] != 'O' && c[2] != 'U' && c[2] != 'Y' && c[6] == '-')
            {
                if ((c[0] + c[1]) % 2 == 0 && (c[3] + c[4]) % 2 == 0 && (c[4] + c[5]) % 2 == 0 && (c[7] + c[8]) % 2 == 0)
                {
                    m = 1;
                }
            }
            if (m == 1)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
