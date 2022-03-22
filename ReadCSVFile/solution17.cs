using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReadCSVFile
{
    class solution17
    {
        void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] array = new string[input.Length];
            string[] output = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                array[i] = Convert.ToString(input[i]);

                if (array[i] == Convert.ToString(input[i]).ToUpper())
                {
                    output[i] = array[i].ToLower();
                }
                else
                {
                    output[i] = array[i].ToUpper();
                }
            }
            foreach (var outp in output)
            {
                Console.Write(outp);
            }

            //  Console.WriteLine(output);
        }
    }
}
