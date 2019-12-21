using System;
using System.Text;

namespace WordCounter.Models
{
    public class Program 
    {
        public static void Main()
        {   
          string wordInput = CheckInput();
          Console.WriteLine("Please enter a complete sentence.");
          string sentenceInput = Console.ReadLine();
          Console.WriteLine("----------------------------------");

          Count firstInstance = new Count(wordInput, sentenceInput);
        
          firstInstance.CountWords();
          Console.WriteLine(firstInstance.Counter);
        }

        public static string CheckInput()
        {
            string finalWord = "";
            Console.WriteLine("Please enter a single word.");
            string word = Console.ReadLine();
            char[] wordArray = word.ToCharArray();
            foreach(char c in wordArray)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '\'')
                {
                    finalWord += c;
                }
                
                else 
                {
                    finalWord = "";  
                    return CheckInput(); 
                }           
            }
            return finalWord;
        }

    }

}



