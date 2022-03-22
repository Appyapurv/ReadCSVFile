using System;
using System.Linq;

namespace ReadCSVFile
{
    class solution63
    {
        //A.input[] = {1,2,3,1,1,2,3,3,3,3,1} Output = 1:4, 2:2, 3:5
        //Explanation: 1 occurs 4 times, 2 occurs 2 times, and 3 occurs 5 times in the given array
        //1,1,2,2,2,2,3
        void Main(string[] args)
        {
            // var input = Console.ReadLine().ToCharArray();
            var ss = new int[] { 1, 1, 1, 1, 2, 2, 3, 3 };
            Array.Sort(ss);
            var ab = ss.Distinct().ToList();
            int ai = 0, bi = 0, ci = 0;
            if (ab.Count() == 3)
            {
                for (int i = 0; i < ss.Length; i++)
                {

                    //foreach (var a in ab)
                    //{
                    if (ss[i] == ab[0])
                    {
                        ai++;
                    }
                    else if (ss[i] == ab[1])
                    {
                        bi++;
                    }
                    else if (ss[i] == ab[2])
                    {
                        ci++;
                    }
                    //}
                }
                Console.WriteLine($"{ai}  {bi}  {ci}");
            }

            else
            {
                Console.WriteLine("NO");
            }

            //for (int i = 0; i < ss.Length; i++)
            //{
            //    var temp = ss[i];
            //    if (ss[i + 1] == temp)
            //    {
            //        counta++;
            //    }
            //    else if (ss[i] != temp && )
            //    {
            //        countb++;
            //    }

            //}

            //1,1,1,1,2,2,2,3,3,3,
            //for (int i = 0; i < input.Length; i++)
            //{
            //var temp = input[i];
            //a = input[i];
            //b = input[i + 1];
            //if (a == b || a !=b )
            //{
            //    ii++;
            //}
            //else if (a != b)
            //{
            //    bb++;
            //}

            //if (input[i + 1].ToString().Contains(temp) == true)
            //{
            //    ii++;
            //}




        }



        // var ss = input.Distinct();





        //for (int i = 0; i < input.Length; i++)
        //{
        //    a = input[i];
        //    if (a == input[i])
        //    {
        //        a++;
        //    }


        //}


        // }
    }
}
