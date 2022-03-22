using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ReadCSVFile
{
    class solution52
    {
        void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            string[] array = Console.ReadLine().Split(' ');
            StringBuilder output = new StringBuilder();
            long half = sizeOfArray / 2;
            long i = 0;
            long num = 0;

            foreach (var arr in array)
            {

                if (i < half)
                {
                    output.Append(arr[0]);
                    i++;
                }
                else if (i >= half)
                {
                    output.Append(arr[arr.Length - 1]);
                    i++;
                }
            }
            string outp = output.ToString();

            for (int j = 0; j < sizeOfArray - 1; j = j + 2)
            {
                int a = Convert.ToInt32(outp[j]);
                int b = Convert.ToInt32(outp[j + 1]);
                num = num + a - b;
            }

            if (Convert.ToDouble(num) % 11 == 0 || num == 0)
            {
                Console.WriteLine("OUI");
            }
            else
            {
                Console.WriteLine("NON");
            }
        }
    }
}
