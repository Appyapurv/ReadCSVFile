using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution3
    {
        //if A = {5,1,3,4,2} and B = {8,10,9,7,6} then a possible sum of product is 5*6 + 1*7 + 3*9 + 4*10 + 2*8.
        void Main(string[] args)
        {
            Console.WriteLine("number of test cases");
            int testcases = Convert.ToInt32(Console.ReadLine());
            for (int s = 0; s < testcases; s++)
            {
                Console.WriteLine("Size of an array");
                int size = Convert.ToInt32(Console.ReadLine());

                int[] array = new int[size];
                int[] array2 = new int[size];
                Console.WriteLine("enter elements in array");
                var arrayValue = Convert.ToString(Console.ReadLine());
                Console.WriteLine("enter elements in array2");
                var array2Value = Convert.ToString(Console.ReadLine());
                var arraySplit = arrayValue.Split(" ", StringSplitOptions.None);
                var array2Split = array2Value.Split(" ", StringSplitOptions.None);
                //assigning value to array
                for (int i = 0; i < arraySplit.Length; i++)
                {
                    array[i] = Convert.ToInt32(arraySplit[i]);
                }
                //assigning value to array2
                for (int i = 0; i < array2Split.Length; i++)
                {
                    array2[i] = Convert.ToInt32(array2Split[i]);
                }
                //sort first array
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            int swap = array[i];
                            array[i] = array[j];
                            array[j] = swap;
                        }
                    }
                }
                //sort second array
                for (int i = 0; i < array2.Length; i++)
                {
                    for (int j = i + 1; j < array2.Length; j++)
                    {
                        if (array2[i] > array2[j])
                        {
                            int swap = array2[i];
                            array2[i] = array2[j];
                            array2[j] = swap;
                        }
                    }
                }
                //sum
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i] * array2[i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
