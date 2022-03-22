using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution21
    {
        //LLRDDR
        void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] leftRightArray = new char[input.Length];
            char[] upDownArray = new char[input.Length];
            int leftRightTotal = 0;
            int upDownTotal = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString().Contains('L') || input[i].ToString().Contains('R') == true)
                {
                    leftRightArray[i] = input[i];
                }
                else if (input[i].ToString().Contains('U') || input[i].ToString().Contains('D') == true)
                {
                    upDownArray[i] = input[i];
                }


            }
            for (int i = 0; i < input.Length; i++)
            {
                if (leftRightArray[i] == 'L')
                {
                    leftRightTotal += -1;
                }
                else if (leftRightArray[i] == 'R')
                {
                    leftRightTotal += +1;
                }
                else if (upDownArray[i] == 'U')
                {
                    upDownTotal += +1;
                }
                else if (upDownArray[i] == 'D')
                {
                    upDownTotal += -1;
                }
            }
            Console.WriteLine($"{leftRightTotal} {upDownTotal}");
        }
    }
}
