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
        [TestMethod]
        public void TestDiv()
        {
            Calculator_ m = new Calculator_();
            double a = 7183.12;
            double b = 653.22;
            double c = 10.996479;
            double res = m.Div(a, b);
            Assert.AreEqual(res.ToString("0.000000"), c.ToString("0.000000"));
        }
        [TestMethod]
        public void TestStepen()
        {
            Calculator_ m = new Calculator_();
            double a = 71.1;
            double b = 3;
            double c = 359425.431;
            double res = m.Stepen(a, b);
            Assert.AreEqual(res.ToString("0.000"), c.ToString("0.000"));
        }
        public void TestSqrt()
        {
            Calculator_ m = new Calculator_();
            double a = 144;
            double b = 2;
            double c = 12;
            double res = m.Sqrt(a, b);
            Assert.AreEqual(res.ToString("0.000"), c.ToString("0.000"));
        }
        [TestMethod]
        public void TestSin()
        {
            Calculator_ m = new Calculator_();
            double a = 78;
            double c = 0.514;
            double res = m.Sin(a);
            Assert.AreEqual(res.ToString("0.000"), c.ToString("0.000"));
        }
        [TestMethod]
        public void TestCos()
        {
            Calculator_ m = new Calculator_();
            double a = 0.95;
            double c = 0.582;
            double res = m.Cos(a);
            Assert.AreEqual(res.ToString("0.000"), c.ToString("0.000"));
        }
    }
}
