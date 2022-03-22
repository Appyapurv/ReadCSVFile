using System;
using System.Linq;

namespace ReadCSVFile
{
    class solution61
    {
        void Main(string[] args)
        {
            String[] line = Console.ReadLine().Split();
            int n = Convert.ToInt32(line[0]);
            long k = Convert.ToInt64(line[1]);
            long[] arr = new long[n];
            arr = Console.ReadLine().Split().Select(num => Convert.ToInt64(num)).ToArray();
            long out_ = Solve(k, arr);
            Console.WriteLine(out_);
        }

        private static long Solve(long k, long[] arr)
        {
            long current = 0;
            long next = 0;
            for (current = 0; current < arr.Length; current++)
            {
                while (arr[current] > 0 && next <= current + k && k >= next - current)
                {
                    if (arr[next] < 0)
                    {
                        long value = Math.Min(arr[current], Math.Abs(arr[next]));
                        arr[current] -= value;
                        arr[next] += value;
                    }
                    else
                    {
                        next++;
                    }
                }
            }
            var sum = arr.Sum(x => Math.Abs(x));
            return sum;
        }
    }
}
