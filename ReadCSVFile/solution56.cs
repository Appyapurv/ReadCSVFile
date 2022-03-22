using System;
using System.Text;

namespace ReadCSVFile
{
    class solution56
    {
        void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());

            for (int t = 0; t < testcases; t++)
            {
                StringBuilder str = new StringBuilder();
                var num = Console.ReadLine().ToCharArray();

                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] == '0' || num[i] == '6' || num[i] == '9')
                    {
                        str.Append("111");
                    }
                    else if (num[i] == '1')
                    {
                        str.Append("1");
                    }
                    else if (num[i] == '2' || num[i] == '3' || num[i] == '5')
                    {
                        str.Append("71");
                    }
                    else if (num[i] == '4')
                    {
                        str.Append("11");
                    }
                    else if (num[i] == '7')
                    {
                        str.Append("7");
                    }
                    else if (num[i] == '8')
                    {
                        str.Append("117");
                    }
                }
                var ss = str.ToString().ToCharArray();
                Array.Sort(ss);
                Array.Reverse(ss);
                new String(ss);

                //Array.Sort(str.ToString());
                Console.WriteLine(new String(ss));
            }
        }
    }
}
