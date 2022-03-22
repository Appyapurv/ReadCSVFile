using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class demo
    {
        private static int runMax = 300;
        private static int ballMax = 50;

        void Main(string[] args)
        {
            int B = 7;
            int R = 7;

            int[,] dp = new int[runMax, ballMax];
            for (int i = 0; i < runMax; i++)
            {

                for (int j = 0; j < ballMax; j++)
                {
                    dp[i, j] = -1;
                }
            }
            int output = ways(0, 0, B, R, dp);
            Console.WriteLine();

        }
        static int ways(int b, int r, int B, int R, int[,] dp)
        {

            if (b == B && r == R)
                return 1;
            if (b > B)
                return 0;
            if (r == R)
                return 1;
            if (r > R)
                return 0;
            int ans = 0;
            if (dp[r, b] != -1)
                return dp[r, b];

            ans = ans + ways(b + 1, r, B, R, dp);
            ans = ans + ways(b + 1, r + 1, B, R, dp);
            ans = ans + ways(b + 1, r + 2, B, R, dp);
            dp[r, b] = ans;
            return ans;

        }
    }
}

