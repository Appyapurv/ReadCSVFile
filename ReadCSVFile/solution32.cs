using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadCSVFile
{
    class solution32
    {
        void Main(string[] args)
        {
            int noOfTestcase = int.Parse(Console.ReadLine());

            for (int i = 0; i < noOfTestcase; i++)
            {
                int size = int.Parse(Console.ReadLine());
                char[] input = Console.ReadLine().ToCharArray();

                int count = 0; ;
                for (int j = 1; j < size; j++)
                {
                    //char temp = input[0];
                    //char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
                    for (int k = j + 1; k < size; k++)
                    {
                        if (input[j] == 'a' && (input[k] != 'a' && input[k] != 'e' && input[k] != 'i' && input[k] != 'o' && input[k] != 'u'))
                        {
                            count++;
                        }
                        else if (input[j] == 'e' && (input[k] != 'a' && input[k] != 'e' && input[k] != 'i' && input[k] != 'o' && input[k] != 'u'))
                        {
                            count++;
                        }
                        else if (input[j] == 'i' && (input[k] != 'a' && input[k] != 'e' && input[k] != 'i' && input[k] != 'o' && input[k] != 'u'))
                        {
                            count++;
                        }
                        else if (input[j] == 'o' && (input[k] != 'a' && input[k] != 'e' && input[k] != 'i' && input[k] != 'o' && input[k] != 'u'))
                        {
                            count++;
                        }
                        else if (input[j] == 'o' && (input[k] != 'a' && input[k] != 'e' && input[k] != 'i' && input[k] != 'o' && input[k] != 'u'))
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine(count);

            }
        }
    }
}
