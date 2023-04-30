using System;

namespace Practice3_3 {
    internal class Program {
        static void Main(string[] args)
{
            Random rnd = new Random();
            int[] arr = new int[200];
            int randomInt;

            for(int i = 0; i < arr.Length; i++) {
                randomInt = rnd.Next(-50, 50);
                arr[i] = randomInt;
                Console.Write(randomInt + " ");
            }
            Console.WriteLine();

            int numberOfIdenticalPairs = 0;
            int previous = arr[0];
            for(int j = 1; j < arr.Length; j++) {
                if(previous == arr[j]) {
                    numberOfIdenticalPairs++;
                }
                previous = arr[j];
            }
            Console.WriteLine("Number of identical pairs = " +  numberOfIdenticalPairs);
            
        }
    }
}

