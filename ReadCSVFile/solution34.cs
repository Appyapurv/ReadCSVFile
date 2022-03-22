using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution34
    {
        void Main(string[] args)
        {
            string num = Console.ReadLine();
            int count = int.Parse(num);

            for (int line = 0; line < count; line++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int cols = int.Parse(input[0]);
                int rows = int.Parse(input[1]);
                int[] size = new int[cols];

                string[][] table = new string[rows + 1][];

                for (int i = 0; i < rows + 1; i++)
                {
                    table[i] = Console.ReadLine().Split(' ');
                }

                size = GetMaxForAllRows(table, cols);

                StringBuilder Seperator = new StringBuilder("+-");
                StringBuilder format = new StringBuilder("| ");
                StringBuilder header = new StringBuilder("| ");

                float test;

                for (int z = 0; z < cols; z++)
                {
                    Seperator.Append(new string('-', size[z]));
                    Seperator.Append("-+");
                    if (z != size.Length - 1)
                    {
                        Seperator.Append("-");
                    }
                    format.Append("{");
                    format.Append(z.ToString());
                    format.Append(",");

                    if (float.TryParse(table[1][z], out test))
                        format.Append(size[z]);
                    else
                        format.Append(-size[z]);

                    format.Append("} |");
                    if (z != size.Length - 1) format.Append(" ");
                    header.Append("{");
                    header.Append(z.ToString());
                    header.Append(",");
                    header.Append(-size[z]);
                    header.Append("} |");
                    if (z != size.Length - 1) header.Append(" ");
                }
                string h = header.ToString();
                string f = header.ToString();

                Console.WriteLine(Seperator);
                Console.WriteLine(string.Format(h, table[0]));
                Console.WriteLine(Seperator);

                for (int r = 1; r <= rows; r++)
                {
                    Console.WriteLine(String.Format(f, table[r]));
                }
                Console.WriteLine(Seperator);

            }
        }

        private static int[] GetMaxForAllRows(string[][] table, int cols)
        {
            int[] rtn = new int[cols];
            for (int i = 0; i < table.GetLength(0); i++)
                for (int j = 0; j < cols; j++)
                    rtn[j] = Math.Max(rtn[j], table[i][j].Length);
            return rtn;
        }
    }
}
