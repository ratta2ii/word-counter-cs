using System;

namespace WordCounter.Models
{
    public class Count
    {
        public string Word { get; set; }
        public string Sentence { get; set; }

        public Count(string word, string sentence)
        {
            Word = word; 
            Sentence = sentence;
        }
        
    }
}