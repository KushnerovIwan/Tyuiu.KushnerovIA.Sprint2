using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint2.Task4.V10.Lib;

namespace Tyuiu.KushnerovIA.Sprint2.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double res = 51;

            Assert.AreEqual(res, ds.Calculate(x, y));
        }
    }
}
