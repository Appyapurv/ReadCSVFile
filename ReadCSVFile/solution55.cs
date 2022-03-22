using System;

namespace ReadCSVFile
{
    class solution55
    {
        public static long ceil(long a, long b) { return a / b + (a % b == 0 ? 0 : 1); }
        public static void assert(bool truthy) { if (!truthy) { var a = 0; a /= a; } }
        void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());

            for (int t = 0; t < testcases; t++)
            {
                //int sum = 0;
                //int count = 0;
                string[] input = Console.ReadLine().Split(' ');
                int kk = int.Parse(input[0]);
                int mm = int.Parse(input[1]);
                int nn = int.Parse(input[2]);
                long ans = 0;
                while (mm > kk)
                {
                    if (mm % nn == 0)
                    {
                        mm /= nn;
                        ans++;
                    }
                    else
                    {
                        var a = mm / nn + 1;
                        var b = a * nn;
                        assert(b > mm);
                        var dt = b - mm;
                        ans += ceil(dt, 2);
                        mm = b;
                    }
                }
                ans += ceil(kk - mm, 2);
                Console.WriteLine(ans);
            }
        }
    }
}