using System;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[,]
            {
                { 11, 7, 50, 45, 27  },
                { 18, 35, 47, 24, 12 },
                { 89, 67, 84, 34, 24 },
                { 67, 32, 79, 65, 10 }
            };

            for (int row = 0;
                 row < numbers.GetLength(0);
                 row++)
            {
                Console.WriteLine(
                  "Maximum number in the row {0}: {1}",
                    row, FindMax(row, numbers));
            }
            Console.WriteLine(
            "Press any key to continue...");
            Console.ReadKey();
        }

        static int FindMax(int row, int[,] numbers)
        {
            int max = numbers[row, 0];
            for (int column = 0;
                 column < numbers.GetLength(1);
                 column++)
            {
                if (numbers[row, column] > max)
                    max = numbers[row, column];
            }
            return max;
        }
    }
}
