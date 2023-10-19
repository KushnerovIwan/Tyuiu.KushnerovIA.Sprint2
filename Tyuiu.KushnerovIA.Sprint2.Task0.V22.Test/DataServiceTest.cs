using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint2.Task0.V22.Lib;

namespace Tyuiu.KushnerovIA.Sprint2.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressoin()
        {
            DataService ds = new DataService();
            int x = 3105;
            int y = 77;
            bool[] res = ds.GetCompareOperations(x, y);
            bool[] prov = { false, true, true, true, true, false };
            CollectionAssert.AreEqual(prov, res);
        }
    }
}
