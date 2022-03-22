using System;

namespace ReadCSVFile
{
    class solution65
    {
        void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());

            for (int t = 0; t < testcases; t++)
            {
                var len = int.Parse(Console.ReadLine());
                var array = new char[len];
                array = Console.ReadLine().ToCharArray();
                int ascci;
                bool prim = true;
                char letter = 'a';

                foreach (var c in array)
                {
                    ascci = Convert.ToInt32(c);
                    bool klein = false;
                    int durchlauf = 0;
                    if (ascci < 133 && ascci > 66)
                    {
                        for (int i = ascci; prim == true;)
                        {
                            prim = false;
                            for (int j = 1; j < i; j++)
                            {
                                if (i % j == 0 && j != 1)
                                {
                                    prim = true;
                                }
                            }
                            if (prim == false)
                            {
                                letter = Convert.ToChar(i);
                            }
                            if (klein == true)
                            {
                                i = i + durchlauf;
                                i++;
                                durchlauf++;
                            }
                            else
                            {
                                i = i - durchlauf;
                                i--;
                                durchlauf++;
                            }
                            klein = !klein;
                        }
                        prim = true;
                        Console.Write(letter);
                    }
                    else if (ascci > 133)
                    {
                        letter = 'q';
                        Console.Write(letter);
                    }
                    else
                    {
                        letter = 'C';
                        Console.Write(letter);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
