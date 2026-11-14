using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.RomanovS.Sprint1.Task7.V23.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            Assert.AreEqual(1.725, new DataService().Calculate(1, 1), 0.001);
        }

        [TestMethod]
        public void CheckCalculateValidSecond()
        {
            Assert.AreEqual(-2.242, new DataService().Calculate(2, 3), 0.001);
        }

        [TestMethod]
        public void CheckCalculateNegativeX()
        {
            Assert.AreEqual(-7.27, new DataService().Calculate(-1, 2), 0.001);
        }
    }
}
