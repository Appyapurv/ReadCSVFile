using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Timers;

namespace ReadCSVFile
{
    class solution36
    {
        void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());
            int SH = 0, EH = 0, SM = 0, EM = 0, H = 0, M = 0;
            StringBuilder output = new StringBuilder();
            for (int t = 0; t < testcases; t++)
            {
                // int HH = 0;
                //int MM = 0;
                string[] input = Console.ReadLine().Split(' ');
                SH = int.Parse(input[0]);
                SM = int.Parse(input[1]);
                EH = int.Parse(input[2]);
                EM = int.Parse(input[3]);

                if (SH < EH)
                {
                    H = (EH - SH);
                    if (SM < EM)
                    {
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
                else
                {
                    H = (24 - SH) + EH;
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
                output.AppendLine(Convert.ToString(H) + " " + Convert.ToString(M));
            }
            Console.WriteLine(output);
        }
    }
}
