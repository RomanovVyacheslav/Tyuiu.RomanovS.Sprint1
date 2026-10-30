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
            //(2*3)/(2+1)-3 = -1
            var res = DataService.Calculate(2, 3);
            Assert.AreEqual(-1, res, 0.001);
        }

        [TestMethod]
        public void CheckCalculateZeroResult()
        {
            //(3*4)/(3+1)-3 = 0
            var res = DataService.Calculate(3, 4);
            Assert.AreEqual(0, res, 0.001);
        }
    }
}
