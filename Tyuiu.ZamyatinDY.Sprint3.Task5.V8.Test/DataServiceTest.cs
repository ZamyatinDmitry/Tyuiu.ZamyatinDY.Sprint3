using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint3.Task5.V8.Lib;
namespace Tyuiu.ZamyatinDY.Sprint3.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 12;
            var res = ds.GetSumSumSeries(startValue1,startValue2 ,stopValue1,stopValue2);
            double wait = 119.066;
            Assert.AreEqual(wait, res);
        }
    }
}
