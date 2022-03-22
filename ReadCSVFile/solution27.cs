using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution27
    {
        void Main(string[] args)
        {
            int testcase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testcase; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                for (int j = 0; j < input.Length - 1; j++)
                {
                    for (int k = 1; k < input.Length; k++)
                    {
                        var input1 = input[j].ToCharArray();
                        Array.Sort(input1);
                        var input2 = input[k].ToCharArray();
                        Array.Sort(input2);

                        if (new string(input1) == new string(input2))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                    }
                }
            }
        }
    }
}

