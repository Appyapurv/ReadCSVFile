using System;
using System.Linq;

namespace ReadCSVFile
{
    class solution64
    {
        void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());

            for (int t = 0; t < testcase; t++)
            {
                var str = Console.ReadLine().ToCharArray();
                var str2 = Console.ReadLine().ToCharArray();

                Array.Sort(str);
                Array.Sort(str2);
                str.Distinct();
                str2.Distinct();

                if (str.ToString().ToLower() == str2.ToString().ToLower())
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
