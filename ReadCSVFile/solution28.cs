using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadCSVFile
{
    class solution28
    {
        void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string a = input[0];
            int[] ab = new int[26];
            int[] bc = new int[26];

            for (int i = 0; i < 26; i++)
            {
                ab[a[i] - 'a']++;
            }

        }
    }
}
