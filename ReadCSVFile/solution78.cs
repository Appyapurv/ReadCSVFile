using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution78
    {
        void Main(string[] args)
        {
            int testcase = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t <= testcase; t++)
            {
                //check for palindrome //aba
                var input = Convert.ToString(Console.ReadLine()).ToCharArray();
                var last = input.Length - 1;
                var flag = true;
                for (int i = 0; i < input.Length / 2; i++)
                {

                    if (Convert.ToString(input[i]).ToLower() == Convert.ToString(input[last]).ToLower())
                    {
                        flag = true;
                        last--;
                    }
                    else
                    {
                        last--;
                        flag = false;
                        break;
                    }
                }
                if (flag) { Console.WriteLine("Yes, Palendrome"); }
                else { Console.WriteLine("No, Palendrome"); }

            }
        }
    }
}
