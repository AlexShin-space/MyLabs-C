using System.Linq;
using System.Xml.Linq;

namespace Practise3_4_part2 {
    internal class Program {
        static void Main(string[] args)
{
            int[][] jagged = new int[4][];
            jagged[0] = new int[6];
            jagged[1] = new int[2];
            jagged[2] = new int[4];
            jagged[3] = new int[11];

            Random rnd = new Random();
            int randomInt;

            Console.WriteLine("Current array:");
            for (int row = 0; row < jagged.GetUpperBound(0) + 1; row++)
            {
                for (int column = 0; column < jagged[row].Length; column++)
                {
                    randomInt = rnd.Next(-50, 50);
                    jagged[row][column] = randomInt;
                    Console.Write("{0,4}", randomInt);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            List<int> numbers = new List<int>(jagged.Length);
            List<int> repeats = new List<int>(jagged.Length);
            for (int row = 0; row < jagged.GetUpperBound(0) + 1; row++)
            {
                for (int column = 0; column < jagged[row].Length; column++)
                {
                    if (numbers.Contains(jagged[row][column]))
                    {
                        repeats[numbers.IndexOf(jagged[row][column])] += 1;
                    }
                    else
                    {
                        numbers.Add(jagged[row][column]);
                        repeats.Add(1);
                    }
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (repeats[i] > 1)
                {
                    Console.WriteLine("Number " + numbers[i] + " has: " + repeats[i] + " repeats");
                }
            }
        }
    }
}

