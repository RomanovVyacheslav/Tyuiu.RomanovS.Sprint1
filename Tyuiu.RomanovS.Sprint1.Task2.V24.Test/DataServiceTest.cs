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
            //(5-3)^2 = 4
            var res = DataService.Calculate(5, 3);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void CheckCalculateNegativeDifference()
        {
            //(3-5)^2 = 4
            var res = DataService.Calculate(3, 5);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void CheckCalculateWithNegativeNumber()
        {
            //(-2-3)^2 = 25
            var res = DataService.Calculate(-2, 3);
            Assert.AreEqual(25, res);
        }
    }
}
