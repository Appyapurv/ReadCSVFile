using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution12
    {
        void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool flag = true;
            //mom POOP
            int j = input.Length - 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[j])
                {
                    flag = false;
                    break;
                }
                j--;
            }
            if (flag)
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
