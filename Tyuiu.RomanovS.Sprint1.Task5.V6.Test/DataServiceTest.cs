using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RomanovS.Sprint1.Task5.V6.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateFirstDay()
        {
            Assert.AreEqual(1, new DataService().Calculate(1));
        }

        [TestMethod]
        public void CheckCalculateSunday()
        {
            Assert.AreEqual(7, new DataService().Calculate(7));
        }

        [TestMethod]
        public void CheckCalculateNextWeek()
        {
            Assert.AreEqual(1, new DataService().Calculate(8));
        }

        [TestMethod]
        public void CheckCalculateLastDay()
        {
            Assert.AreEqual(1, new DataService().Calculate(365));
        }

        [TestMethod]
        public void CheckCalculateMiddle()
        {
            Assert.AreEqual(2, new DataService().Calculate(100));
        }
    }
}
