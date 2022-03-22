using System;

namespace ReadCSVFile
{
    class solution68
    {
        void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            int openBracket = 0;
            int closeBracket = 0;
            foreach (var i in input)
            {
                if (i == '(')
                {
                    openBracket++;
                }
                else if (i == ')')
                {
                    closeBracket++;
                }
            }
            if (openBracket == closeBracket)
            {
                Console.WriteLine(openBracket);
            }

        }
    }
}
