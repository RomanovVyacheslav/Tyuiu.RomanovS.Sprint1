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
            Assert.IsTrue(DataService.Calculate("абв"));
        }

        [TestMethod]
        public void CheckCalculateNotOrderedRussian()
        {
            Assert.IsFalse(DataService.Calculate("авб"));
        }

        [TestMethod]
        public void CheckCalculateOrderedLatinWithCase()
        {
            Assert.IsTrue(DataService.Calculate("AbC"));
        }

        [TestMethod]
        public void CheckCalculateNotOrderedLatin()
        {
            Assert.IsFalse(DataService.Calculate("Hello"));
        }

        [TestMethod]
        public void CheckCalculateIgnoresNotLetters()
        {
            Assert.IsTrue(DataService.Calculate("а, б; в 123"));
        }

        [TestMethod]
        public void CheckCalculateEmptyString()
        {
            Assert.IsTrue(DataService.Calculate(""));
        }
    }
}
