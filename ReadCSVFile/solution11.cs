using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution11
    {
        void Main(string[] args)
        {
            int[] poleA;
            int[] poleB;
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int result = 0;
                poleA = new int[26];
                poleB = new int[26];
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                for (int j = 0; j < a.Length; j++)
                {
                    poleA[a[j] - 'a']++;
                }
                for (int j = 0; j < b.Length; j++)
                {
                    poleB[b[j] - 'a']++;
                }
                for (int j = 0; j < 26; j++)
                {
                    if (poleA[j] > poleB[j])
                        result += poleA[j] - poleB[j];
                    else
                        result += poleB[j] - poleA[j];
                }
                Console.WriteLine(result);
            }
        }
    }
}
