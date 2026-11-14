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
            double res = new DataService().ReverseNumber(123);
            Assert.AreEqual(321, res, 0.001);
        }

        [TestMethod]
        public void CheckCalculateWithZeroUnits()
        {
            double res = new DataService().ReverseNumber(120);
            Assert.AreEqual(21, res, 0.001);
        }
    }
}
