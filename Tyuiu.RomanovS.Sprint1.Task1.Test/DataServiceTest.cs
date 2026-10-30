using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RomanovS.Sprint1.Task1.V0.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateExpressionValid()
        {
            var res = DataService.CalculateExpression();
            Assert.AreEqual(-10.5, res, 0.001);
        }
    }
}
