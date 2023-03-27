using CalcTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        BasicMaths bm = new BasicMaths();
        public double res;


        [TestMethod]
       
        public void TestAddMethod1()
        {
            res = bm.Add(10, 10);
            Assert.AreEqual(res,20);
        }
        [TestMethod]
        public void TestSubtractMethod()
        {
            res = bm.Subtract(10, 10);
            Assert.AreEqual(res,0);
        }
        [TestMethod]
        public void TestDivideMethod()
        {
            res =bm.Divide(100, 10);
            Assert.AreEqual(res,10);
        }
        [TestMethod]
        public void TestMulMethod()
        {
            res = bm.Mul(5, 5);
            Assert.AreEqual(res,25);
        }
    }
}
