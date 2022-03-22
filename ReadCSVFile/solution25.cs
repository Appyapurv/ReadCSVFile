using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution25
    {
        void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split(' ');
            int[] intputArray = new int[size];
            double sum = 0;
            bool flag = true;
            int opt = 1;
            int value = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                intputArray[i] = int.Parse(array[i]);
                sum += intputArray[i];
            }

            for (int i = 0; i < intputArray.Length; i++)
            {
                if (sum % 7 == 0)
                {
                    if (sum % intputArray[i] == 0)
                    {
                        if (value > intputArray[i])
                        {
                            Console.WriteLine(i);
                            opt = 2;
                            break;
                        }
                        value = intputArray[i];

                        Console.WriteLine(i);
                        opt = 2;
                        break;
                    }
                    flag = false;
                }
                flag = false;
            }
            if (flag == false && opt == 1)
            {
                Console.WriteLine("-1");
            }
        }
    }
}