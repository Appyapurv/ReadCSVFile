using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReadCSVFile
{
    class solution2
    {
         void Main(string[] args)
        {
            string name = "MOM";
            var lenght = name.Length - 1;
            bool flag = true;
            for (int i = 0; i < name.Length / 2; i++)
            {
                if (name[i] != name[lenght - i])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Paliendrome:");
            }
            else
            {
                Console.WriteLine("Not Paliendrome:");
            }
        }
    }
}
