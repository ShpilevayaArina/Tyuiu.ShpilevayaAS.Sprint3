using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint3.Task0.V8.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint3.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 2;
            int startValue = 1;
            int stoptValue = 3;

            double res = ds.GetMultiplySeries(value, startValue, stoptValue);

            double wait = -37.701;

            Assert.AreEqual(wait, res);
        }
    }
}
