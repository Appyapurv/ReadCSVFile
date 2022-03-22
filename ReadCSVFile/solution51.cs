using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution51
    {
        void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var s = Console.ReadLine().Split(' ');
            if (Convert.ToInt32(s[s.Length - 1]) % 10 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
