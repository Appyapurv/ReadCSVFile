using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution14
    {
        void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testcases; i++)
            {
                int GreenBalloonCost = 0;
                int PurpleBalloonCost = 0;

                var BallonCost = Console.ReadLine().Split(' ');
                //find some generic logic for this
                GreenBalloonCost = int.Parse(BallonCost[0]);
                PurpleBalloonCost = int.Parse(BallonCost[1]);
                int exp = PurpleBalloonCost;
                int cheap = GreenBalloonCost;
                if (GreenBalloonCost > PurpleBalloonCost)
                {
                    exp = GreenBalloonCost;
                    cheap = PurpleBalloonCost;
                }

                int numberOfParticipants = int.Parse(Console.ReadLine());
                int[,] status = new int[numberOfParticipants, 2];

                for (int j = 0; j < numberOfParticipants; j++)
                {
                    var ss = Console.ReadLine().Split(' ');
                    for (int k = 0; k < ss.Length; k++)
                    {
                        status[j, k] = int.Parse(ss[k]); 

                    }
                }


                int sum1 = 0;
                int sum2 = 0;
                int sum = 0;
                //sum
                for (int l = 0; l < numberOfParticipants; l++)
                {
                    sum1 += status[l, 0];
                    sum2 += status[l, 1];
                    if (sum1 < sum2)
                    {
                        sum = sum1 * exp + sum2 * cheap;
                    }
                    else
                    {
                        sum = sum2 * exp + sum1 * cheap;
                    }
                }

                Console.WriteLine(sum);


            }
        }
    }
}
