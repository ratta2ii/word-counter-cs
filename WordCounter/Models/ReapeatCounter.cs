using System;

namespace WordCounter.Models
{
    public class Count
    {
        string Word { get; set; }
        string Sentence { get; set; }

        public Count(string word, string sentence)
        {
            Word = word; 
            Sentence = sentence;
        }
        
    }
}