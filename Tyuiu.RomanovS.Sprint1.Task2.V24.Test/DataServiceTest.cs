using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RomanovS.Sprint1.Task2.V24.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            int res = new DataService().CalculateDiffSquare(5, 3);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void CheckCalculateNegativeDifference()
        {
            int res = new DataService().CalculateDiffSquare(3, 5);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void CheckCalculateWithNegativeNumber()
        {
            int res = new DataService().CalculateDiffSquare(-2, 3);
            Assert.AreEqual(25, res);
        }
    }
}
