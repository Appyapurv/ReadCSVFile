using System;

namespace ReadCSVFile
{
    class solution66
    {
        void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());
            var input1 = Console.ReadLine().Split(' ');
            var input2 = Console.ReadLine().Split(' ');

            int max = int.MinValue;
            int min = int.MaxValue;
            int[] a = new int[numberOfInput];

            for (int i = 0; i < numberOfInput; i++)
            {
                a[i] = int.Parse(input1[i]) - int.Parse(input2[i]);
                if (max < a[i])
                {
                    max = a[i];
                }

                if (min > a[i])
                {
                    min = a[i];
                }

            }

            Console.WriteLine(max - min);

        }
    }
}
