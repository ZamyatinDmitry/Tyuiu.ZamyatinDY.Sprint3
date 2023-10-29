﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint3.Task7.V10.Lib;
namespace Tyuiu.ZamyatinDY.Sprint3.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] valueWaitArray;
            int len = stopValue - startValue + 1;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -15.40;
            valueWaitArray[1] = -13.31;
            valueWaitArray[2] = -11.36;
            valueWaitArray[3] = -8;
            valueWaitArray[4] = -2.62;
            valueWaitArray[5] = 1.83;
            valueWaitArray[6] = 4.49;
            valueWaitArray[7] = 6.78;
            valueWaitArray[8] = 10.58;
            valueWaitArray[9] = 17.38;
            valueWaitArray[10] = 23.76;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, valueWaitArray);


        }
    }
}
