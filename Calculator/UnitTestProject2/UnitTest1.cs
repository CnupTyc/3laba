using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            Calculator_ m = new Calculator_();
            double a = 5;
            double b = 6;
            double c = 11;
            double res = m.Sum(a, b);
            Assert.AreEqual(res.ToString("0.000"), c.ToString("0.000"));
        }

    }
}
