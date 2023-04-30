using System;
using System.Globalization;

namespace Practice5_3 { //17   bad hello nice mam waw beeb better goood
    internal class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Enter your words: ");
            string[] sentence = Console.ReadLine().Split(" ");

            int j;
            for (int i = 1; i < sentence.Length; i++){
                
                if(sentence[0] != sentence[i]) {
                    //List<char> word = sentence[i].ToCharArray().ToList();
                    for (j = 0; j < sentence[i].Length; j++){

                        //Console.WriteLine(sentence[i].IndexOf(sentence[i][j]) +" != "+ sentence[i].LastIndexOf(sentence[i][j]) + "    " +
                             //sentence[i].LastIndexOf(sentence[i][j]) +" != "+ (sentence[i].Length - 1 - sentence[i].IndexOf(sentence[i][j]))
                            //);
                        //check for dublicates
                        if (sentence[i].IndexOf(sentence[i][j]) != sentence[i].LastIndexOf(sentence[i][j]) &&
                            sentence[i].LastIndexOf(sentence[i][j]) != (sentence[i].Length - 1 - sentence[i].IndexOf(sentence[i][j]))
                            ) {
                            break;
                        }

                        //check for symmetry
                        if (sentence[i][j] != sentence[i][sentence[i].Length - 1 - j]) {
                            break;
                        }
                    }

                    if (j >= sentence[i].Length - 1)
                    {
                        Console.WriteLine(sentence[i]);
                    }
                }
            }
            Console.ReadLine();
        }
    }   
}