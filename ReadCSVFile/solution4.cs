using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution4
    {
        //reverse a string 
        //revese a character
        void Main(string[] args)
        {
            string name = "apurv";
            var ss = name.ToCharArray();

            char[] fname = "apurv".ToCharArray();
            char[] output = new char[fname.Length];
            int j = 0;
            for (int i = fname.Length - 1; i >= 0; i--)
            {
                output[j] = fname[i];
                j++;
            }
        }
    }
}
