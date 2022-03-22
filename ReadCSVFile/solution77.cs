using System;
using System.Text;

namespace ReadCSVFile
{
    class solution77
    {
        void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int[] alphaCount = new int[26];
            int[] alpha = new int[26];
            int count = 0;
            for (int i = 0; i < 26; i++)
            {
                alpha[i] = 'a' + i;
            }

            for (int t = 0; t < testcases; t++)
            {
                string input = Console.ReadLine();
                count = 0;
                alphaCount = new int[26];
                foreach (char c in input.ToCharArray())
                {
                    alphaCount[c - 97]++;
                }

                for (int i = 0; i < 26; i++)
                {
                    if (alphaCount[i] != 0)
                    {
                        count++;
                        if (count > 1)
                            break;
                    }
                }
                if (count == 1)
                {
                    sb.Append("-1");
                }
                else
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (alphaCount[i] > 0)
                        {
                            sb.Append(new string((char)alpha[i], alphaCount[i]));
                        }
                    }
                }
                sb.AppendLine();

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
