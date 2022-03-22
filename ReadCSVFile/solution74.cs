using System;
using System.Text;

namespace ReadCSVFile
{
    class solution74
    {
        void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            string x = input[0];
            int k = int.Parse(input[1]);
            var output = 0;
            StringBuilder ss = new StringBuilder();

            for (int i = 0; i < k; i++)
            {
                ss.Append(9);
            }
            for (int i = k; i < x.Length; i++)
            {
                ss.Append(x[i]);
            }
            Console.WriteLine(ss.ToString());


        }
    }
}
