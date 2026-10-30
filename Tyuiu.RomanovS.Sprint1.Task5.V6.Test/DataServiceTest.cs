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
            //1 января - понедельник
            Assert.AreEqual(1, DataService.Calculate(1));
        }

        [TestMethod]
        public void CheckCalculateSunday()
        {
            //7-й день - воскресенье
            Assert.AreEqual(7, DataService.Calculate(7));
        }

        [TestMethod]
        public void CheckCalculateNextWeek()
        {
            //8-й день - снова понедельник
            Assert.AreEqual(1, DataService.Calculate(8));
        }

        [TestMethod]
        public void CheckCalculateLastDay()
        {
            //365-й день - понедельник (364 = 52 * 7)
            Assert.AreEqual(1, DataService.Calculate(365));
        }

        [TestMethod]
        public void CheckCalculateMiddle()
        {
            //100-й день - вторник
            Assert.AreEqual(2, DataService.Calculate(100));
        }
    }
}
