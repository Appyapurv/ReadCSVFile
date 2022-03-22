using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;

namespace DataStuture
{
    class solution4
    {
        void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());
            int[] output = new int[testcase];

            for (int t = 0; t < testcase; t++)
            {
                int[] input1 = new int[testcase];
                int[] input2 = new int[testcase + 1];

                var input11 = Console.ReadLine().Split();
                for (int i = 0; i < input11.Length; i++)
                {
                    input1[i] = int.Parse(input11[i]);
                }
                var input22 = Console.ReadLine().Split();
                for (int i = 0; i < input22.Length; i++)
                {
                    input2[i] = int.Parse(input22[i]);
                }

                var last = input1.LastOrDefault();
                int count = 0;

                count = checkvalue(input2, last, count);

                if (count >= 1)
                {
                    for (int i = 0; i < input2.Length; i++)
                    {
                        input2[i] = input2[i] + 1;
                    }
                }
                else
                {
                    output[testcase] = count;
                }
                //  while(count<=0)



            }
        }

        private static int checkvalue(int[] input2, int last, int count)
        {
            for (int i = 0; i < input2.Length; i++)
            {
                if (input2[i] > last)
                {
                    count = count + 1;
                }
            }

            return count;
        }
    }
}
