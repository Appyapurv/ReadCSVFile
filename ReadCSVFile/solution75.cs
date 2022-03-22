using System;

namespace ReadCSVFile
{
    class solution75
    {
        void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var x = input[0];
            var k = int.Parse(input[1]);
            string output = string.Empty;
            int i = 0;

            while (i < x.Length)
            {
                if (k > 0 && x[i] != '9')
                {
                    output += "9";
                    k--;
                }
                else
                {
                    output += x[i];
                }
                i++;
            }
            Console.WriteLine(output);
        }
    }
}
