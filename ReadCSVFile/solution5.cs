using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution5
    {
         void Main(string[] args)
        {
            //palindrome
            string name = "MO7qpq7OM";
            var size = name.Length - 1;
            bool flag = false;
            for (int i = 0; i < name.Length / 2; i++)
            {
                if (name[i] != name[size - i])
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Not a palindrome");
            }
            else
            {
                Console.WriteLine("palindrome");
            }
        }
    }
}
