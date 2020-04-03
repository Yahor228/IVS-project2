using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalc.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void MyAdd()
        {
            MyCalc c = new MyCalc();

            double actual = c.Add(10, 20);
            Assert.AreEqual(30, actual);

            double actual2 = c.Add(10, -20);
            Assert.AreEqual(-10, actual2);
            Assert.AreNotSame(actual, actual2);

            double actual3 = c.Add(0.005, 0.002);
            Assert.AreEqual(0.007, actual3);
            Assert.IsTrue(actual3 == 0.0070);

            double actual4 = c.Add(-5, 2);
            Assert.AreNotEqual(3, actual4);
        }
        [TestMethod]
        public void MySub()
        {
            MyCalc d = new MyCalc();

            double actual = d.Sub(10, 20);
            Assert.AreEqual(-10, actual);
            Assert.IsFalse(actual == 0.0070);

            double actual2 = d.Sub(10, -20);
            Assert.AreEqual(30, actual2);

            double actual3 = d.Sub(0.005, 0.002);
            Assert.AreEqual(0.003, actual3);

            double actual4 = d.Sub(-5, 2);
            Assert.AreNotEqual(3, actual4);
            Assert.AreNotSame(actual, actual4);
        }
        [TestMethod]
        public void MyMul()
        {
            MyCalc a = new MyCalc();
            double actual = a.Mul(5, 2);
            Assert.AreEqual(10, actual);

            double actual1 = a.Mul(0.005, 0.1);
            Assert.AreEqual(0.0005, actual1);
            Assert.IsFalse(actual1 == 0.000700);

            double actual2 = a.Mul(-46, -88);
            Assert.AreEqual(4048, actual2);

            double actual3 = a.Mul(789987, 0);
            Assert.AreEqual(0, actual3);

            double actual4 = a.Mul(789987, 0);
            Assert.AreEqual(0, actual4);
            Assert.IsTrue(actual4 == 0.00);
        }
        [TestMethod]
        public void MyDiv()
        {
            MyCalc a = new MyCalc();
            double actual = a.Div(100, 2);
            Assert.AreEqual(50, actual);

            double actual1 = a.Div(0.005, -0.1);
           // Assert.AreEqual(-0.05, actual1);
            Assert.IsFalse(actual1 == 0.05);

            double actual2 = a.Div(0, 4567);
            Assert.AreEqual(0, actual2);
            Assert.IsNotNull(actual2);

            double actual3 = a.Div(789987, 1);
            Assert.AreEqual(789987, actual3);
            Assert.IsTrue(actual2 == 0.00);

            double actual4 = a.Div(789987, 0);
            Assert.AreNotEqual(0, actual4);
        }
    }
}

