using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadCSVFile
{
    class solution20
    {
        void Main(string[] args)
        {
            int numberOfgrid = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            char[] array = new char[input.Length];
            int j = input.Length - 1;
            bool flag = true;

            for (int i = 0; i < input.Length; i++)
            {
                array[i] = input[i];

                if (array[i].ToString().Contains('.') == true)
                {
                    array[i] = Convert.ToChar(array[i].ToString().Replace('.', 'B'));
                }
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1] && array[i] == 'H')
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine("YES");
                foreach (var s in array)
                {
                    Console.Write(s);
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
