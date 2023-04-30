using System;

namespace Practice5 { //13
    internal class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Enter your sentence: ");
            string[] sentence = Console.ReadLine().Split(" ");
            Console.WriteLine("Enter your char key: ");
            char key = Convert.ToChar( Console.ReadLine() );

            foreach(string i in sentence) {
                if (i[0] == key) Console.Write(i+" ");
            }

            Console.ReadLine();
        }
    }   
}