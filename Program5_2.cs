using System;

namespace Practice5_2 { //16
    internal class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Enter your sentence: ");
            string[] sentence = Console.ReadLine().ToLower().Split(" ");

            var currentWord = "";
  
            for (int i = 0; i < sentence.Length; i++){
                currentWord = sentence[i];
                for(int j = i + 1; j < sentence.Length; j++){
                    if(currentWord == sentence[j]) {
                        Console.Write("Duplicate word: " + sentence[j]);
                        Console.ReadLine();
                        return;
                    }
                }
                if(i == sentence.Length-1)
                {
                    Console.WriteLine("Can't find duplicate words");
                    Console.ReadLine();
                }
            }
        }
    }   
}