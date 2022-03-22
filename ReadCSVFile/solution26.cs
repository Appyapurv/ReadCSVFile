using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadCSVFile
{
    class solution26
    {
        void Main(String[] args)
        {
            int numOfTestCases = Convert.ToInt32(Console.ReadLine());
            double[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            double sum = arr.Sum();
            double min = int.MaxValue;
            int Index = -1;

            for (int i = 0; i < numOfTestCases; i++)
            {
                double temp = sum - arr[i];

                if (temp % 7 == 0)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                        Index = i;
                    }
                }
            }


            Console.WriteLine(Index);

        }
    }
}
