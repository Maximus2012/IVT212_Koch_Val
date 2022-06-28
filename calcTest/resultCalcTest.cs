<<<<<<< HEAD
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculate;

namespace calcTest
{

   



    [TestClass]
    public class resultCalcTest
    {
        [TestMethod]
        public void TestMethodPlus()
        {
            fCalc calc = new fCalc();
            double a = 10; double b = 15;
            double expected = 25;
            double result;
            result = calc._bRavno_Click(a, b, 1);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodMinus()
        {
            fCalc calc = new fCalc();
            double a = 1; double b = 9;
            double expected = -8;
            double result;
            result = calc._bRavno_Click(a, b, 2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodMultiply()
        {
            fCalc calc = new fCalc();
            double a = 10; double b = 10;
            double expected = 100;
            double result;
            result = calc._bRavno_Click(a, b, 3);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodDivide()
        {
            fCalc calc = new fCalc();
            double a = 10; double b = 5;
            double expected = 2;
            double result;
            result = calc._bRavno_Click(a, b, 4);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodPow()
        {
            fCalc calc = new fCalc();
            double a = 5; double b = 10;
            double expected = Math.Pow(a, b);
            double result;
            result = calc._bRavno_Click(a, b, 5);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodSin()
        {
            Operations operation = new Operations();
            double a = 1;
            double expected = 0.8415; double result;
            result = operation.sin(a);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodCos()
        {
            Operations operation = new Operations();
            double a = 1;
            double expected = 0.5403; double result;
            result = operation.cos(a);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodTan()
        {
            Operations operation = new Operations();
            double a = 1;
            double expected = 1.5574; double result;
            result = operation.tan(a);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodCtg()
        {
            Operations operation = new Operations();
            double a = 1,c;
            double expected = 0.6421; double result;
            c= operation.tan(a);
            result = Math.Round(1 / c,4);
            Assert.AreEqual(expected, result);
        }
    }
    
}
=======
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculate;

namespace calcTest
{

   



    [TestClass]
    public class resultCalcTest
    {
        [TestMethod]
        public void TestMethodPlus()
        {
            fCalc calc = new fCalc();
            double a = 5; double b = 10;
            double expected = 15;
            double result;
            result = calc._bRavno_Click(a, b, 1);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodMinus()
        {
            fCalc calc = new fCalc();
            double a = 10; double b = 5;
            double expected = 5;
            double result;
            result = calc._bRavno_Click(a, b, 2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodMultiply()
        {
            fCalc calc = new fCalc();
            double a = 5; double b = 10;
            double expected = 50;
            double result;
            result = calc._bRavno_Click(a, b, 3);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodDivide()
        {
            fCalc calc = new fCalc();
            double a = 10; double b = 5;
            double expected = 2;
            double result;
            result = calc._bRavno_Click(a, b, 4);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodPow()
        {
            fCalc calc = new fCalc();
            double a = 5; double b = 10;
            double expected = Math.Pow(a, b);
            double result;
            result = calc._bRavno_Click(a, b, 5);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodSin()
        {
            Operations operation = new Operations();
            double a = 1;
            double expected = 0.8415; double result;
            result = operation.sin(a);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodCos()
        {
            Operations operation = new Operations();
            double a = 1;
            double expected = 0.5403; double result;
            result = operation.cos(a);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodTan()
        {
            Operations operation = new Operations();
            double a = 1;
            double expected = 1.5574; double result;
            result = operation.tan(a);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethodCot()
        {
            Operations operation = new Operations();
            double a = 0.78539;
            double expected = 1; double result; double perem;
            perem = operation.tan(a);
            result = 1 / perem;
            Assert.AreEqual(expected, result);
        }

    }
    
}
>>>>>>> 5e629d2d3dcd5bddaa0aa088e01542eb6a307dec
