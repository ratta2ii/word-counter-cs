using System;

namespace WordCounter.Models
{
    public class Program 
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");

            Console.Write("Please enter a single word.");
            string word1 = Console.ReadLine();
            Console.Write("Please enter a complete sentence.");
            string sentence1 = Console.ReadLine();
            Console.WriteLine("----------------------------------");

            Count example1 = new Count(word1, sentence1);
            Console.WriteLine($"I am the example1 instance: {example1}");
            Console.WriteLine($"I a am the instance word: {example1.Word}");
            Console.WriteLine($"I am the instance sentence: {example1.Sentence}");

        
        }
    }
}