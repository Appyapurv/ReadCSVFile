using System;

namespace ReadCSVFile
{
    class solution69
    {
        void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            int bal = 0, count = 0, min = 5;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    bal++;
                }
                else
                {
                    bal--;
                }
                if (min > bal)
                {
                    min = bal;
                    count = 0;
                }
                if (min == bal)
                {
                    count++;
                }
            }
            if (bal == 0)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
