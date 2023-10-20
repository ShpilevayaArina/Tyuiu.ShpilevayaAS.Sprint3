using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint3.Task3.V4.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint3.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();

            string value = "joker has joken";
            char item = 'j';

            string res = ds.DeleteCharInString(value, item);
            string wait = "oker has oken";

            Assert.AreEqual(wait, res);


        }
    }
}
