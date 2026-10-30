using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RomanovS.Sprint1.Task4.V6.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            //|3^2 - 2| / (2*3) = 7/6 = 1.167
            var res = DataService.Calculate(2, 3);
            Assert.AreEqual(1.167, res, 0.001);
        }

        [TestMethod]
        public void CheckCalculateZeroResult()
        {
            //|1^2 - 1| / (1*1) = 0
            var res = DataService.Calculate(1, 1);
            Assert.AreEqual(0, res, 0.001);
        }
    }
}
