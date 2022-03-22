using System;

namespace ReadCSVFile
{
    class solution58
    {
        void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            double max = int.MinValue;
            double sum = 0;
            var array = Console.ReadLine().Split(' ');

            for (int i = 0; i < size; i++)
            {
                sum = sum + Convert.ToDouble(array[i]);
            }

            //for (int i = 0; i < size; i++)
            //{
            //    sum = Convert.ToDouble(array[i]);
            //    for (int j = i + 1; j < size - i; j++)
            //    {
            //        sum = sum+ Convert.ToDouble(array[j]) + Convert.ToDouble(array[j + 1]);
            //        for (int k = j + 1; k < size - j; k++)
            //        {
            //            sum = sum+ Convert.ToDouble(array[k]) + Convert.ToDouble(array[k + 1]) + Convert.ToDouble(array[k + 2]);
            //        }
            //    }
            //    if (sum < max)
            //    {
            //        max = sum;
            //    }
            //    Console.WriteLine(max);
            //}

        }
    }
}
