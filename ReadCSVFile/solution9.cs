using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReadCSVFile
{
    class solution9
    {
        void Main(string[] args)
        {
            var input = Convert.ToString(Console.ReadLine());
            char[] arrayInput = input.ToArray();
            int zCount = 0;
            int oCount = 0;

            foreach (char c in arrayInput)
            {
                if (c == 'z' || c == 'Z')
                {
                    zCount++;
                }
                if (c == 'o' || c == 'O')
                {
                    oCount++;
                }
            }
            if (oCount / 2 == oCount)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadLine();
        }
    }
}
