using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution40
    {
        void Main(String[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int total = 0;
            decimal pie = (decimal)22 / (decimal)7;

            for (int d = 0; d < days; d++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int Radius = int.Parse(input[0]);
                int amountOfHorlicks = int.Parse(input[1]);

                decimal area = (decimal)2 * pie * (decimal)Radius;
                decimal capableOf = 100 * (decimal)amountOfHorlicks;
                if (area < capableOf)
                {
                    total++;
                }
            }
            Console.WriteLine(total);
        }
    }
}
