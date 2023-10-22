using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint3.Task2.V20.Lib;
namespace Tyuiu.ZamyatinDY.Sprint3.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int start1 = 1;
            int finish2 = 6;
            var res = ds.GetMultiplySeries(value, start1, finish2);
            double wait = 914700.94;
            Assert.AreEqual(wait, res);
        }
    }
}
