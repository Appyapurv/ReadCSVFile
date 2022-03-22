using System;
using System.Collections.Generic;
using System.Text;

namespace ReadCSVFile
{
    class solution18
    {
        void Main(String[] args)
        {
            int dimension = int.Parse(Console.ReadLine());
            int numberOfPhotos = int.Parse(Console.ReadLine());
            int[,] value = new int[numberOfPhotos, 2];

            for (int i = 0; i < numberOfPhotos; i++)
            {
                var input = Console.ReadLine().Split(' ');
                for (int j = 0; j < input.Length; j++)
                {
                    value[i, j] = int.Parse(input[j]);
                }
            }

            //logic 
            for (int i = 0; i < value.Length / 2; i++)
            {
                int flag = 0;
                int sum = 0;
                for (int j = 0; j < 2; j++)
                {

                    if (sum == value[i, j])
                    {

                        if (dimension < sum || dimension < value[i, j])
                        {
                            flag = 1;// 1 is greter
                            break;
                        }
                        else if (dimension > sum || dimension < value[i, j])
                        {
                            flag = 2;// 2 is for less
                            break;
                        }
                        else if (dimension == sum && dimension == value[i, j] || sum == value[i, j])
                        {
                            flag = 0;//equal
                        }
                    }

                    sum = value[i, j];
                }
                switch (flag)
                {
                    case 0:
                        Console.WriteLine("ACCEPTED");
                        break;
                    case 1:
                        Console.WriteLine("CROP IT");
                        break;
                    case 2:
                        Console.WriteLine("UPLOAD ANOTHER");
                        break;
                }
                //if (flag == 0)
                //{
                //    Console.WriteLine("ACCEPTED");
                //}
                //else if (flag == 2)
                //{
                //    Console.WriteLine("UPLOAD ANOTHER");
                //}
                //else if (flag == 1)
                //{
                //    Console.WriteLine("CROP IT");
                //}
            }

        }
    }
}
