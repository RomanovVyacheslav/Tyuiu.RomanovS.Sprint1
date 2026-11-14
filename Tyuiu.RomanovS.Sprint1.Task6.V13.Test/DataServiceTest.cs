using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RomanovS.Sprint1.Task6.V13.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateOrderedRussian()
        {
            Assert.IsTrue(new DataService().CheckWordsAlphabet("абв"));
        }

        [TestMethod]
        public void CheckCalculateNotOrderedRussian()
        {
            Assert.IsFalse(new DataService().CheckWordsAlphabet("авб"));
        }

        [TestMethod]
        public void CheckCalculateOrderedLatinWithCase()
        {
            Assert.IsTrue(new DataService().CheckWordsAlphabet("AbC"));
        }

        [TestMethod]
        public void CheckCalculateNotOrderedLatin()
        {
            Assert.IsFalse(new DataService().CheckWordsAlphabet("Hello"));
        }

        [TestMethod]
        public void CheckCalculateIgnoresNotLetters()
        {
            Assert.IsTrue(new DataService().CheckWordsAlphabet("а, б; в 123"));
        }

        [TestMethod]
        public void CheckCalculateEmptyString()
        {
            Assert.IsTrue(new DataService().CheckWordsAlphabet(""));
        }
    }
}
