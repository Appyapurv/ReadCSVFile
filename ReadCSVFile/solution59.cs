using System;
using System.Linq;

namespace ReadCSVFile
{
    class solution59
    {
        private static long maxSum = 0;
        private static int bestIndex = 0;
        void Main(string[] args)
        {
            var line = Console.ReadLine();
            int n = 0;
            Int32.TryParse(line, out n);

            var numbers = Console.ReadLine().Split(' ').Select(d => { int temp = 0; Int32.TryParse(d, out temp); return temp; }).ToArray();
            //find the most appropriate size
            var temp2 = (int)((Math.Pow(1 + 8 * n, 0.5) - 1) / 2);
            var length = temp2 * (temp2 + 1) / 2;

            long currentSum = 0;

            //find the starting sum
            for (int i = 0; i < length; i++)
            {
                currentSum += numbers[i];
            }
            maxSum = currentSum;
            //for each index  afterward see what it does
            for (int i = 1; i < n; i++)
            {
                currentSum -= numbers[i - 1];
                if (i + length > n)
                {
                    length -= temp2;
                    temp2--;

                    for (int x = 0; x < temp2; x++)
                    {
                        currentSum -= numbers[n - 1 - x];
                    }
                }
                else
                {
                    currentSum += numbers[i + length - 1];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    bestIndex = i;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
