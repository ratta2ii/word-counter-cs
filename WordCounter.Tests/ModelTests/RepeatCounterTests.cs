using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
    [TestClass]
    public class CountTest 
    {

        [TestMethod]
        public void CountConstructor_CreateInstanceOfRepCount_RepeatCounter()
        {
            string word = "dog";
            string sentence = "How are you today?";
            Count rcTest = new Count(word, sentence);
            Assert.AreEqual(typeof(Count), rcTest.GetType());
        }

        [TestMethod]

        public void CountWords_CountsWordsInSentence_1()
        {
            string word = "dog";
            string sentence = "It truly does make sense that a dog has been called mans best friend.";
            Count testInstance = new Count(word, sentence);
            testInstance.CountWords();
            Assert.AreEqual(1, testInstance.Counter);
        }

        [TestMethod]

        public void CountWords_CountsWordsInSentence_2()
        {
            string word = "beach";
            string sentence = "The beach has always been a part of my life, as I have been going to the beach since early childhood.";
            Count testInstance = new Count(word, sentence);
            testInstance.CountWords();
            Assert.AreEqual(2, testInstance.Counter);
        }

        [TestMethod]

        public void CountWords_CountsWordsInSentence_0()
        {
            string word = "photo";
            string sentence = "It has always been a dream of mine to get into photography.";
            Count testInstance = new Count(word, sentence);
            testInstance.CountWords();
            Assert.AreEqual(0, testInstance.Counter);
        }

        [TestMethod]
        public void RemoveSpecialChars_RemovesAllSpecialChars_String()
        {
            string sentence = "Hello there Frank, how are you?";
            string result = "hello there frank how are you";
            Assert.AreEqual(result, Count.RemoveSpecialChars(sentence));
        }

    }
}




