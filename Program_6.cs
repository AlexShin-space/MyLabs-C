using System;
using System.Text;

namespace Practice6 { //1 variant
    internal class Program {
        [Flags]
        enum Items {
            None = 0,

            Philosophy = 1,
            Science_of_law = 2,
            Foreign_Language= 3,

            Computer_discrete_mathematics = 4,
            Information_technologies_in_professional_activity = 5,
            Fundamentals_of_programming = 6,

            Computer_architecture = 7,
            Computer_graphics_and_data_visualization = 8,
            Fundamentals_of_cyber_security = 9
        }
        static void Main(string[] args) {


            for (int i = 1; i < 10; i++) {
                Console.WriteLine(i + ". " + (Items)i);
            }

            Console.WriteLine("\nPlease, select the subjects: ");
            string[] stringAnswer = Console.ReadLine().Split(",");
            int[] intAnswer = new int[stringAnswer.Length];
            for (int i = 0; i < stringAnswer.Length; i++) {
                intAnswer[i] = Convert.ToInt32(stringAnswer[i]);
            }
            
            Console.WriteLine("\nBasic disciplins:");
            foreach (var item in intAnswer){
                if(item > 0 && item < 4) {
                    Console.WriteLine(item + ". "+(Items)item);
                }
            }
            Console.WriteLine("\nCompulsory disciplins:");
            foreach (var item in intAnswer){
                if(item > 3 && item < 7) {
                    Console.WriteLine(item + ". "+(Items)item);

                }
            }
            Console.WriteLine("\nOptional disciplins:");
            foreach (var item in intAnswer){
                if(item > 6 && item < 10) {
                    Console.WriteLine(item + ". "+(Items)item);
                }
            }

            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("\nШиндін Олександр Дмитрович");
            Console.ReadLine();
        }
    }   
}