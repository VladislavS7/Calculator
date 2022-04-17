using CalcClasss;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcClasssTests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void AddTest()
        {
            double input1 = 2;
            double input2 = 3;
            double expected = 5;
            double actual = CalcClass.Add(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubTest()
        {
            double input1 = 2;
            double input2 = 3;
            double expected = -1;
            double actual = CalcClass.Sub(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MulTest()
        {
            double input1 = 2;
            double input2 = 3;
            double expected = 6;
            double actual = CalcClass.Mult(input1, input2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Div_10divide0_Exception()
        {
            double input1 = 10;
            double input2 = 0;
            double actual = CalcClass.Div(input1, input2);
        }

        [TestMethod]
        public void DivTest()
        {
            double input1 = 10;
            double input2 = 2;
            double expected = 5;
            double actual = CalcClass.Div(input1, input2);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ABSTestPlus()
        {
            double input = 10;
            double expected = 10;
            double actual = CalcClass.ABS(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ABSTestMinus()
        {
            double input = -2;
            double expected = 2;
            double actual = CalcClass.ABS(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IABSTest()
        {
            double input = 12;
            double expected = 12;
            double actual = CalcClass.IABS(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IABSTestMinus()
        {
            double input = -12;
            double expected = 12;
            double actual = CalcClass.IABS(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
