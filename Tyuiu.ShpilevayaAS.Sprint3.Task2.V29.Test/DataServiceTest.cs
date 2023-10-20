using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint3.Task2.V29.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint3.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 2;
            int startValue = 0;
            int stoptValue = 0;

            double res = ds.GetSumSeries(value, startValue, stoptValue);

            double wait = 1.25;

            Assert.AreEqual(wait, res);
        }
    }
}
