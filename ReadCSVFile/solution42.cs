using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution42
    {
        void Main(string[] args)
        {
            int noOfPeople = int.Parse(Console.ReadLine());
            int minimumSkill = int.Parse(Console.ReadLine());

            for (int i = 0; i < noOfPeople; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input < minimumSkill)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
