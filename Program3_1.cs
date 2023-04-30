namespace ConsoleApp4 {
    internal class Program {
        static void Main(string[] args)
{
            Random rnd = new Random();
            int[] arr = new int[10];
            int randomInt;

            for(int i = 0; i < arr.Length; i++) {
                randomInt = rnd.Next(-100, 100);
                arr[i] = randomInt;
                Console.Write("{0,5}", randomInt);
            }
            Console.WriteLine();

            for(int j = 0; j <= arr.ToList().IndexOf(arr.Max()); j++) {
                if(arr[j] < 0) {
                    arr[j] = 0;
                }
            }

            foreach (var element in arr)
            {
                Console.Write("{0,5}", element);
            }
        }
    }
}

