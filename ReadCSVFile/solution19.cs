using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution19
    {
         void Main(string[] args)
        {
            int dim = int.Parse(Console.ReadLine());
            int noOfPhotos = int.Parse(Console.ReadLine());

            //logic
            for (int i = 0; i < noOfPhotos; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var s1 = int.Parse(input[0]);
                var s2 = int.Parse(input[1]);

                if (dim < s1 || dim < s2)
                {
                    Console.WriteLine("CROP IT");
                    break;
                }
                else if (dim > s1 || dim > s2)
                {
                    Console.WriteLine("UPLOAD ANOTHER");
                    break;
                }
                else if (s1 == s2)
                {
                    Console.WriteLine("ACCEPTED");
                    break;
                }
                else if (dim == s1 && dim == s2)
                {
                    Console.WriteLine("ACCEPTED");
                    break;
                }
            }

        }
    }
}
