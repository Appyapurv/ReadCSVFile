using System;
using System.Numerics;

namespace ReadCSVFile
{
    class solution70
    {
        void Main(string[] args)
        {
            while (true)
            {
                var inputs = Console.ReadLine();
                if (inputs == null)
                {
                    break;
                }
                string[] inp = inputs.Split(' ');
                BigInteger num1 = BigInteger.Parse(inp[0]);
                BigInteger num2 = BigInteger.Parse(inp[1]);
                BigInteger sum = num1 + num2;
                Console.WriteLine(sum);
            }
        }
    }
}
