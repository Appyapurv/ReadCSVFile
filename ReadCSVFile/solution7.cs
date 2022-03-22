using System;
namespace ReadCSVFile
{
    class solution7
    {
        public void Main(string[] args)
        {
            // 1-12 list
            int num = Convert.ToInt32(Console.ReadLine());
            int check = num % 12;
            if (check == 0)
            {
                Console.WriteLine($"{num - 11} WS");
            }
            else if (check == 1)
            {
                Console.WriteLine($"{num + 11} WS");
            }
            else if (check == 2)
            {
                Console.WriteLine($"{num + 9} MS");
            }
            else if (check == 3)
            {
                Console.WriteLine($"{num + 7} AS");
            }
            else if (check == 4)
            {
                Console.WriteLine($"{num + 5} AS");
            }
            else if (check == 5)
            {
                Console.WriteLine($"{num + 3} MS");
            }
            else if (check == 6)
            {
                Console.WriteLine($"{num + 1} WS");
            }
            else if (check == 7)
            {
                Console.WriteLine($"{ num - 1} WS");
            }
            else if (check == 8)
            {
                Console.WriteLine($"{num - 3} MS");
            }
            else if (check == 9)
            {
                Console.WriteLine($"{ num - 5} AS");
            }
            else if (check == 10)
            {
                Console.WriteLine($"{num - 7} AS");
            }
            else if (check == 11)
            {
                Console.WriteLine($"{num - 9} MS");
            }
        }
    }
}
