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

        [TestMethod]
        public void TestSub()
        {
            Calculator_ m = new Calculator_();
            double a = 11.777;
            double b = 6.111;
            double c = 5.666;
            double res = m.Sub(a, b);
            Assert.AreEqual(res.ToString("0.000"), c.ToString("0.000"));
        }

        [TestMethod]
        public void TestMul()
        {
            Calculator_ m = new Calculator_();
            double a = 11;
            double b = 653.1;
            double c = 7184.1;
            double res = m.Mul(a, b);
            Assert.AreEqual(res.ToString("0.000"), c.ToString("0.000"));
        }

    }
}
