using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution41
    {
        void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int lengthOfBook = int.Parse(input[0]);
            int noOfPages = int.Parse(input[1]);

            if (lengthOfBook <= 23 && noOfPages >= 500 && noOfPages <= 1000)
            {
                Console.WriteLine("Take Medicine");
            }
            else
            {
                Console.WriteLine("Don't take Medicine");
            }
        }
    }
}
