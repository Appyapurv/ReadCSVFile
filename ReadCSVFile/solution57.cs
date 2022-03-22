using System;
using System.Text;

namespace ReadCSVFile
{
    class solution57
    {
        void Main(string[] args)
        {
            var T = int.Parse(Console.ReadLine());
            int count = 0;
            while (T > 0)
            {
                var m1 = Console.ReadLine().ToCharArray();
                int x1 = 0;
                for (int i = 0; i < m1.Length; i++)
                {
                    if (Convert.ToInt32(m1[i] - '0') == 0 || Convert.ToInt32(m1[i] - '0') == 6 || Convert.ToInt32(m1[i] - '0') == 9)
                    {
                        x1 = x1 + 6;
                    }
                    else if (Convert.ToInt32(m1[i] - '0') == 2 || Convert.ToInt32(m1[i] - '0') == 3 || Convert.ToInt32(m1[i] - '0') == 5)
                    {
                        x1 = x1 + 5;
                    }
                    else if (Convert.ToInt32(m1[i] - '0') == 1)
                    {
                        x1 = x1 + 2;
                    }
                    else if (Convert.ToInt32(m1[i] - '0') == 4)
                    {
                        x1 = x1 + 4;
                    }
                    else if (Convert.ToInt32(m1[i] - '0') == 8)
                    {
                        x1 = x1 + 7;
                    }
                    else if (Convert.ToInt32(m1[i] - '0') == 7)
                    {
                        x1 = x1 + 3;
                    }
                }

                StringBuilder str = new StringBuilder();
                if (x1 % 2 != 0 && x1 > 2)
                {
                    int temp = x1 / 2;
                    count = temp - 1;
                    str.Append(7);
                    for (int i = 0; i < count; i++)
                    {
                        str.Append(1);
                    }
                }
                else if (x1 % 2 != 0 && x1 < 2)
                {
                    str.Append(1);
                }
                else
                {
                    count = x1 / 2;
                    for (int i = 0; i < count; i++)
                        str.Append(1);
                }
                Console.WriteLine(str);
                T--;
            }
        }
    }
}
