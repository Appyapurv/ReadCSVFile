using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution37
    {
        void Main(String[] args)
        {
            int testcases = int.Parse(Console.ReadLine());
            int SH, EH, SM, EM, H, M = 0;
            StringBuilder output = new StringBuilder();

            for (int t = 0; t < testcases; t++)
            {
                string[] input = Console.ReadLine().Split(' ');

                SH = int.Parse(input[0]);
                SM = int.Parse(input[1]);
                EH = int.Parse(input[2]);
                EM = int.Parse(input[3]);


                if (SH < EH)
                {
                    H = EH - SH;
                    if (SM < EM)
                    {
                        M = EM - SM;
                    }
                    else
                    {
                        M = (EM + 60) - SM;
                        H = H - 1;
                    }
                    if (M == 60)
                    {
                        M = 0;
                        H = H + 1;
                    }
                }
                else
                {
                    H = (EH + 24) - SH;
                    if (SM < EM)
                    {
                        if (SH == EH)
                        {
                            H = 0;
                            M = EM - SM;
                        }
                        else
                        {
                            M = (60 - SM) + EM;
                            H = H - 1;
                        }
                        if (M == 60)
                        {
                            M = 0;
                            H = H + 1;
                        }
                    }
                }
                output.AppendLine(H.ToString() + " " + Convert.ToString(M));
            }
            Console.WriteLine(output);
        }
    }
}
