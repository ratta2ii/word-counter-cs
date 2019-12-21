using System;

namespace WordCounter.Models
{
    public class Count
    {
        public string Word { get; set; }
        public string Sentence { get; set; }
        public int Counter { get; set; }
        
        public Count(string word, string sentence)
        {
            Word = word; 
            Sentence = sentence;
            Counter = 0;
        }

        public void CountWords()
        {
            string sentence = RemoveSpecialChars(Sentence);
            string[] sentArr = sentence.Split(" ");
            foreach(string i in sentArr)
            {
                if (i == Word)
                {
                    Counter++;
                }
            } 
        }

        public static string RemoveSpecialChars(string sentence)
        {
            string sentToLower = sentence.ToLower();
            string sentenceCleaned = "";
            char[] sentenceArr = sentToLower.ToCharArray();
            foreach(char c in sentenceArr)
            {
                if ((c >= 'a' && c <= 'z') || (c == ' ') || (c == '\''))
                {
                    sentenceCleaned += c;
                }
            }
            return sentenceCleaned;
        }
        
    }

}