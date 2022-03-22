using System;

namespace ReadCSVFile
{
    class solution73
    {
        void Main(string[] args)
        {
            var testcases = int.Parse(Console.ReadLine());
            for (int t = 0; t < testcases; t++)
            {
                var str = Console.ReadLine();
                long sum = 0;
                long su = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 'a' || str[i] == 'z')
                    {
                        sum += (str.Length - i) * (su + 1);
                        su = 0;
                    }
                    else
                        su++;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
