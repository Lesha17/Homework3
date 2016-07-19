using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework3.Model;

namespace Homework3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLoad_1()
        {
            IFrqData frq = Frq.LoadAsync("../../all_2.frq").Result;

            Assert.IsNotNull(frq.Data);
            Assert.IsTrue(frq.Data.Count > 0);
        }
    }
}
