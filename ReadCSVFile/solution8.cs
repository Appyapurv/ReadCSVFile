using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution8
    {
        // First line: A word that starts with several Zs and continues by several Os.
        //Note: The maximum length of this word must be 20.
        //input- zzzoooooo   output- Yes  x+2Y   zzzoooooo zooo zo  zz0000  
        void Main(string[] args)
        {
            //use distinct 
            var str = Convert.ToString(Console.ReadLine());
            var strSplit = str.ToCharArray();
            bool flag = true;
            var ss = strSplit.Length / 2;

            for (int i = 0; i < strSplit.Length; i++)
            {
                if (strSplit[0] != 'z' && strSplit.Length > 20)
                {
                    flag = false;
                    break;
                }
                if (strSplit[i] != 'z' && strSplit[i] != 'o')
                {
                    flag = false;
                    break;
                }

            }
            //zoo zzoooo zzzoooooo
            if (strSplit[ss] == 'o')
            {
                if (strSplit.Length % 2 == 0)
                {
                    if (strSplit[ss - 1] == 'o')
                    {
                        flag = true;
                        // break;
                    }
                    else { flag = false; }
                }
                else
                {
                    if (strSplit[ss - 1] != 'o')
                    {
                        flag = false;
                        // break;
                    }
                }
            }
            else { flag = false; }
            if (flag)
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
