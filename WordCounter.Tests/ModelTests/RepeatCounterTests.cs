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
            string word = "running";
            string sentence = "I want to go running in the moring";
            Count testInstance = new Count(word, sentence);
            Assert.AreEqual(1, testInstance.Counter);
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




