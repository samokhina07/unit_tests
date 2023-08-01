using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_1_1158()
        {
            //arange
            double x = -1;
            double expected = -1.158;
            //act
            WindowsFormsApp4.Form1 c = new WindowsFormsApp4.Form1();
            double actual = c.Method1(x);
            actual = Math.Round(actual, 3);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_05_14()
        {
            //arange
            double x = 0.5;
            double expected = -14;
            //act
            WindowsFormsApp4.Form1 c = new WindowsFormsApp4.Form1();
            double actual = c.Method2(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_1_054()
        {
            //arange
            double x = 1;
            double expected = 0.54;
            //act
            WindowsFormsApp4.Form1 c = new WindowsFormsApp4.Form1();
            double actual = c.Method3(x);
            actual = Math.Round(actual, 2);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_double_1_2316()
        {
            //arange
            double x = -1;
            double expected = -2.316;
            //act
            WindowsFormsApp4.Form1 c = new WindowsFormsApp4.Form1();
            double actual = c.Method1(x);
            actual = Math.Round(actual, 3);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_double_05_28()
        {
            //arange
            double x = 0.5;
            double expected = -28;
            //act
            WindowsFormsApp4.Form1 c = new WindowsFormsApp4.Form1();
            double actual = c.Method2(x);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_double_1_108()
        {
            //arange
            double x = 1;
            double expected = 1.08;
            //act
            WindowsFormsApp4.Form1 c = new WindowsFormsApp4.Form1();
            double actual = c.Method3(x);
            actual = Math.Round(actual, 2);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_3_0()
        {
            //arange
            double x = 3;
            double expected = 0;
            //act
            WindowsFormsApp4.Form1 c = new WindowsFormsApp4.Form1();
            double actual = c.Method1(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_3_0111()
        {
            //arange
            double x = 3;
            double expected = -0.111;
            //act
            WindowsFormsApp4.Form1 c = new WindowsFormsApp4.Form1();
            double actual = c.Method2(x);
            actual = Math.Round(actual, 3);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_3_033()
        {
            //arange
            double x = 3;
            double expected = -0.33;
            //act
            WindowsFormsApp4.Form1 c = new WindowsFormsApp4.Form1();
            double actual = c.Method3(x);
            actual = Math.Round(actual, 2);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_double_3_066()
        {
            //arange
            double x = 3;
            double expected = -0.66;
            //act
            WindowsFormsApp4.Form1 c = new WindowsFormsApp4.Form1();
            double actual = c.Method3(x);
            actual = Math.Round(actual, 2);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}