using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint3.Task6.V15.Lib;
namespace Tyuiu.ZamyatinDY.Sprint3.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 6;
            int stopValue = 15;
            var res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 168;
            Assert.AreEqual(wait, res);
        }
    }
}
