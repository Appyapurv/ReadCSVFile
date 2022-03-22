using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadCSVFile
{
    class solution33
    {
        void Main(string[] args)
        {
            List<char> vowels = new List<char>();
            vowels.Add('a');
            vowels.Add('e');
            vowels.Add('i');
            vowels.Add('o');
            vowels.Add('u');

            bool isLastConsonant = false;
            int count = 0;
            int testcase = int.Parse(Console.ReadLine());

            for (int r = 0; r < testcase; r++)
            {
                int size = int.Parse(Console.ReadLine());

                var input = Console.ReadLine().ToList();
                foreach (char item in input)
                {
                    if (vowels.Contains(item))
                    {
                        isLastConsonant = true;
                    }
                    else if (isLastConsonant)
                    {
                        count++;
                        isLastConsonant = false;
                    }


                    //if (!vowels.Contains(item))
                    //{
                    //    isLastConsonant = true;
                    //}
                    //else if (isLastConsonant)
                    //{
                    //    if (vowels.Contains(item))
                    //    {
                    //        count++;
                    //        isLastConsonant = false;
                    //    }
                    //}
                }
                isLastConsonant = false;
                Console.WriteLine(count);
                count = 0;
            }
        }
    }
}
