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
            double res = new DataService().Calculate(2, 3);
            Assert.AreEqual(1.167, res, 0.001);
        }

        [TestMethod]
        public void CheckCalculateZeroResult()
        {
            double res = new DataService().Calculate(1, 1);
            Assert.AreEqual(0, res, 0.001);
        }
    }
}
