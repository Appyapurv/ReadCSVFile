using System;
using System.Collections.Generic;

namespace ReadCSVFile
{
    class solution72
    {
        void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < 10; i++)
            {
                dict.Add(i, 0);
            }
            for (int i = 0; i < input.Length; i++)
            {
                /* if(int.Parse(input[0].ToString())==*/
                if (dict.ContainsKey(int.Parse(input[i].ToString())) == true)
                {
                    var value = dict.GetValueOrDefault(int.Parse(input[i].ToString()));
                    dict[int.Parse(input[i].ToString())] = value + 1;
                    //dict.GetObjectData(1)
                }

            }
            foreach (var ss in dict)
            {
                Console.WriteLine($"{ss.Key} {ss.Value}");
            }
        }
    }
}
