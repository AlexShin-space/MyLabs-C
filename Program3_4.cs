using System;

namespace Practice3_4 {
    internal class Program {
        static void Main(string[] args)
{
            Random rnd = new Random();
            int[,] matrix = new int[5, 5];
            int randomInt;

            Console.WriteLine("Random matrix:");
            for (int row = 0; row < matrix.GetUpperBound(0) + 1; row++) {
                for(int column = 0; column < matrix.GetUpperBound(1) + 1; column++) {
                    randomInt = rnd.Next(-50, 50);
                    matrix[row, column] = randomInt;
                    Console.Write("{0,4}", randomInt);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] rotatedMatrix = new int[5, 5];
            for (int row = 0; row < rotatedMatrix.GetUpperBound(0) + 1; row++)
            {
                for (int column = 0; column < rotatedMatrix.GetUpperBound(1) + 1; column++)
                {
                    rotatedMatrix[column, rotatedMatrix.GetUpperBound(0) - row] = matrix[row, column];
                }
            }

            Console.WriteLine("Changed matrix:");
            for (int row = 0; row < matrix.GetUpperBound(0) + 1; row++)
            {
                for (int column = 0; column < matrix.GetUpperBound(1) + 1; column++)
                {
                    Console.Write("{0,4}", rotatedMatrix[row, column]);
                }
                Console.WriteLine();
            }

        }
    }
}

