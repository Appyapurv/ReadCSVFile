using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadCSVFile
{
    class solution49
    {
        void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int Q = int.Parse(input[1]);

            var array = Console.ReadLine().Split(' ').ToList(); ;

            for (int i = 0; i < Q; i++)
            {
                string[] querry = Console.ReadLine().Split(' ');
                int Q1 = int.Parse(querry[0]);
                int Q2 = int.Parse(querry[1]);

                if (array.Contains(Q1.ToString()) == true)
                {
                    if (array.Contains(Q2.ToString()) == true)
                    {
                        //   array.Find(o=>o.)
                    }
                }

            }
        }
    }
}
