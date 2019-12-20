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
        public void RepCountConstructor_CreateInstanceOfRepCount_RepeatCounter()
        {
            string word1 = "dog";
            string sentence1 = "How are you today?";
            Count rcTest = new Count(word1, sentence1);
            Assert.AreEqual(typeof(Count), rcTest.GetType());
        }

    }
}




