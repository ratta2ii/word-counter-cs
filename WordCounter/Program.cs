using System;

namespace WordCounter.Models
{
    public class Program 
    {
        public static void Main()
        {   
            string word = CheckInput();
            Console.WriteLine("Please enter a complete sentence.");
            string sentence = Console.ReadLine();
            Console.WriteLine("----------------------------------");

            Count example1 = new Count(word, sentence);
           

            example1.CountWords();
            Console.WriteLine(example1.Counter);
        }

        public static string CheckInput()
        {
            string word = "";
            Console.WriteLine("Please enter a single word.");
            word = Console.ReadLine();
            char[] wordArray = word.ToCharArray();
            bool result = word.All(Char.IsLetter);
            if (!result)
            {
                word = "";
                return CheckInput();
            }
            return word;
        }
    }
}

