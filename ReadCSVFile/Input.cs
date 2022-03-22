using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReadCSVFile
{
    class Input
    {
         void Main(String[] args)
        {
            int[] inputArray = new int[] { 4, 2, 1, 3, 2, 4, 5, 6, 1, 2 };
            int[] sss = new int[inputArray.Length];
            int p = 0;
            foreach(var aa in inputArray)
            {
                sss[p]=aa;
                p++;
            }
            Array.Sort(sss);


            //for (int i = 0; i < inputArray.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < inputArray.Length; j++)
            //    {
            //        if (inputArray[i] > inputArray[j])
            //        {
            //           int swap = array[i];
            //            inputArray[i] = inputArray[j];
            //            inputArray[j] = swap;
            //        }
            //    }
            //}




            List<int> ss = new List<int>();
            foreach (int s in inputArray)
            {
                ss.Add(s);
            }
            var array = ss.ToArray();
            //var ss1 = array.OrderByDescending(o => o).ToArray();            
            int[] outputArray = new int[inputArray.Length];
            int swap = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
                }
            }
            int k = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == array[k])
                {
                    if (array[k] == array[k + 1])
                    {
                        k++;
                    }
                    outputArray[i] = array[k + 1];
                }
                else if (inputArray[i] > array[k])
                {
                    outputArray[i] = array[k];
                }
            }
            Console.WriteLine(outputArray);
        }
    }
}

