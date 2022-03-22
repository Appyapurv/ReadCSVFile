using System;
using System.Collections.Generic;

namespace ReadCSVFile
{
    class solution71
    {
        void Main(string[] args)
        {
            var testcase = int.Parse(Console.ReadLine());

            for (int t = 0; t < testcase; t++)
            {
                var str = Console.ReadLine();
                var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
                long result = 0;

                for (var i = 0; i < str.Length; i++)
                {
                    if (vowels.Contains(str[i]))
                    {
                        result += str.Length - i;
                    }
                }
                if (result == 0)
                {
                    Console.WriteLine(0);
                    continue;
                }
                long sum = vowels.Contains(str[0])
                    ? result - str.Length : result;
                for (int i = 1; i < str.Length; i++)
                {
                    result += sum;

                    if (vowels.Contains(str[i]))
                    {
                        var newSum = sum - (str.Length - i);
                        sum = newSum;

                        if (sum == 0)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine(result);
            }
        }
    }

}

