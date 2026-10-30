using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RomanovS.Sprint1.Task3.V14.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            //123 -> 321
            var res = DataService.Calculate(123);
            Assert.AreEqual(321, res, 0.001);
        }

        [TestMethod]
        public void CheckCalculateWithZeroUnits()
        {
            //120 -> 021 = 21
            var res = DataService.Calculate(120);
            Assert.AreEqual(21, res, 0.001);
        }
    }
}
