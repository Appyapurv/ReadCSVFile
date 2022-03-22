using System;

namespace ReadCSVFile
{
    class solution67
    {
        void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());
            var a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            // int min = a[0];
            // int max = int.MinValue;
            int min = int.MaxValue;
            // int[] a = new int[numberOfInput];
            int steps = 0;

            for (int i = 0; i < numberOfInput; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            for (int i = 0; i < numberOfInput; i++)
            {
                if (a[i] <= min)
                {
                    min = a[i];
                    continue;
                }
                if (a[i] != min && a[i] >= b[i])
                {
                    while (a[i] > min && a[i] >= b[i])
                    {
                        a[i] = a[i] - b[i];
                        steps++;
                        if (a[i] < min)
                            min = a[i];
                    }
                }
                else
                    break;
            }

            bool isEqual = true;
            for (int i = 0; i < numberOfInput - 1; i++)
            {
                if (a[i] != a[i + 1])
                    isEqual = false;
            }

            if (isEqual)
                Console.WriteLine(steps);
            else
                Console.WriteLine("-1");
        }
    }
}
