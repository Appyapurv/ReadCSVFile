using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution16
    {
        void Main(String[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            double fact = 1;
            //factorial logic 
            for (int i = 1; i <= input; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
