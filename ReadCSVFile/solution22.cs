using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution22
    {
        void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int count = input;
            for (int i = 1; i < count; i++)
            {
                input = input - i;
                if (input <= 0)
                {
                    Console.WriteLine("Patlu");
                    break;
                }
                input = input - (i * 2);
                if (input <= 0)
                {
                    Console.WriteLine("Motu");
                    break;
                }
            }

            //int[] arr = new int[input];
            //bool flag = false;
            //int sum = 0;
            //for (int i = 1; i <= input / 2; i++)
            //{
            //    for (int j = i + 1; j <= input; j++)
            //    {
            //        sum += i + j * 2;
            //        break;
            //    }

            //    //for (int j = i + 1; j < i * 2; j++)
            //    //{
            //    //    //arr[j] = j;
            //    //    if (arr[j] == input)
            //    //    {
            //    //        flag = true;
            //    //    }
            //    //}
            //}
            //if (flag)
            //{
            //    Console.WriteLine("Motu");
            //}
            //else
            //{
            //    Console.WriteLine("Patlu");
            //}
        }
    }
}
