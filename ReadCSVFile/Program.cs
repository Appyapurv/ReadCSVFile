using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ReadCSVFile
{
    //Input: arr[] = { 4, 2, 1, 3 }
    //Output: arr[]= { 1, 1, 2, 1 }
    //Explanation:
    //For arr[0], the smallest out of the remaining elements is 1. So arr[0] is replaced by 1.
    //For arr[1], the smallest out of the remaining elements is 1. So arr[1] is replaced by 1.
    //For arr[2], the smallest out of the remaining elements is 2. So arr[2] is replaced by 2.
    //For arr[3], the smallest out of the remaining elements is 1. So arr[3] is replaced by 1
    class Program
    {
         void Main(string[] args)
        {
            int[] inputarray = new int[] { 4, 2, 1, 3 };

            int[] outputArray = new int[inputarray.Length];



            for (int i = 0; i < inputarray.Length; i++)
            {
                var Max= int.MaxValue;
                for (int j = 0; j < inputarray.Length; j++)
                {
                    if (inputarray[j] < Max && inputarray[i] != inputarray[j])
                    {
                        Max = inputarray[j];
                    }
                }
                outputArray[i] = Max;

            }
            Console.WriteLine();




















            //int[] outputarray = new int[inputarray.Length];
            //int j = 0;

            //List<int> outputArray = new List<int>();

            //var minVal = inputarray.Min();

            //foreach (var item in inputarray)
            //{
            //    if (item > minVal)
            //    {
            //        outputArray.Add(minVal);
            //    }
            //    else
            //    {
            //        outputArray.Add(minVal + 1);
            //    }
            //}


            //foreach (int input in inputarray)
            //{
            //    for (int i = 0; i < inputarray.Length; i++)
            //    {
            //        if (input > inputarray[i])
            //        {
            //            if (input != inputarray[i])
            //            {
            //                outputarray[j] = inputarray[i];
            //            }
            //            else if (input == inputarray[i])
            //            {
            //                inputarray.Skip(inputarray[i]);
            //                for (int k = 0; k < inputarray.Length; k++)
            //                {
            //                    outputarray[j] = inputarray[k];
            //                    // break;
            //                }
            //            }
            //        }
                    //j++;
                    //else if (inputarray[i] >= inputarray[i + 1]) { outputarray[j] = inputarray[i + 1]; }
                    //else if (inputarray[i] >= inputarray[i + 2]) { outputarray[j] = inputarray[i + 2]; }
                    //else if (inputarray[i] >= inputarray[i + 3]) { outputarray[j] = inputarray[i + 3]; }

                    //    //}
                    //    //j++;
                    //    Console.WriteLine(outputarray);
                    //}
                    //Console.WriteLine(outputarray);
                }
    }
}

