using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReadCSVFile
{
    class solution10
    {
         void Main(string[] args)
        {
            int testcase = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < testcase; i++)
            {
                //two user input string
                string str = Console.ReadLine();
                string str1 = Console.ReadLine();

                char[] charStr = str.ToCharArray();
                char[] charStr1 = str1.ToCharArray();

                string finalstr = "";
                string finalstr1 = "";

                //sort charStr
                Array.Sort(charStr);
                Array.Sort(charStr1);
                int s = 0;
                int t = 0;
                for (int j = 0; j < charStr.Length; j++)
                {
                    if (charStr1.Contains(charStr[j]) != true)
                    {
                        finalstr = $"{finalstr}{charStr[j]}";
                        s++;
                    }
                }

                for (int j = 0; j < charStr1.Length; j++)
                {
                    if (charStr.Contains(charStr1[j]) != true)
                    {
                        finalstr1 = $"{finalstr1}{charStr1[j]}";
                        finalstr1.Append(charStr1[j]);
                        t++;
                    }
                }
                //sum

                int sum = finalstr.Length + finalstr1.Length;
                Console.WriteLine(sum);

            }
        }
    }
}
