using System;
using System.Text;

namespace ReadCSVFile
{
    class solution60
    {
        static StringBuilder output = new StringBuilder();
        void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            int value = int.Parse(Console.ReadLine());

            foreach (var b in input)
            {
                if (b >= 48 && b <= 57)
                {
                    if ((b + value) > 57)
                    {
                        FindCipherText(b, value);
                    }
                    else
                    {
                        output.Append((char)(b + value));
                    }
                }
                else if (b >= 65 && b <= 90)
                {
                    if ((b + value) > 90)
                    {
                        FindCipherText(b, value);
                    }
                    else
                    {
                        output.Append((char)(b + value));
                    }
                }
                else if (b >= 97 && b <= 122)
                {
                    if ((b + value) > 122)
                    {
                        FindCipherText(b, value);
                    }
                    else
                    {
                        output.Append((char)(b + value));
                    }
                }
                else
                {
                    output.Append(b);
                }
            }
            Console.WriteLine(output.ToString());
        }

        private static void FindCipherText(char c, int key)
        {
            int difference = 0;
            if (c >= 48 && c <= 57)
            {
                difference = (key % 10);
                if ((c + difference) > 57)
                {
                    int minusValue = (57 - c) > 0 ? (57 - c) + 1 : 1;
                    output.Append((char)((48 + difference) - minusValue));
                }
                else
                {
                    output.Append((char)(c + difference));
                }
            }
            else if (c >= 97 && c <= 122)
            {
                difference = (key % 26);
                if ((c + difference) > 122)
                {
                    int minusValue = (122 - c) > 0 ? (122 - c) + 1 : 1;
                    output.Append((char)((97 + difference) - minusValue));
                }
                else
                {
                    output.Append((char)(c + difference));
                }
            }

            else if (c >= 65 && c <= 90)
            {
                difference = key % 26;
                if ((c + difference) > 90)
                {
                    int minusValue = ((90 - c)) > 0 ? (90 - c) + 1 : 1;
                    output.Append((char)((65 + difference) - minusValue));
                }
                else
                {
                    output.Append((char)(c + difference));
                }
            }
        }
    }
}