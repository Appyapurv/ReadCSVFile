using System;

namespace ReadCSVFile
{
    class solution13
    {
        void Main(String[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] array = new int[sizeOfArray];
            double sum = 1;

            var input = Console.ReadLine().Split(' ');

            //read value 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(input[i]);
            }
            //logic
            var func = (Math.Pow(10, 9) + 7);
            for (int j = 0; j < array.Length; j++)
            {
                sum = (sum * array[j]) % func;
            }
            Console.WriteLine(sum);
        }
    }
}
