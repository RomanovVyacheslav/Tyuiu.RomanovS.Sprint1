using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RomanovS.Sprint1.Task1.V18.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            double res = new DataService().Calculate(2, 3);
            Assert.AreEqual(-1, res, 0.001);
        }

        [TestMethod]
        public void CheckCalculateZeroResult()
        {
            double res = new DataService().Calculate(3, 4);
            Assert.AreEqual(0, res, 0.001);
        }
    }
}
