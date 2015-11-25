using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class EvaluateTests
    {
        [TestMethod]
        public void EvaluateEnsureICanCreateAClassInstance()
        {
            Evaluate test = new Evaluate();
            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void EvaluateEnsureProperAddOperation()
        {
            Parse test = new Parse();
            Evaluate addTest = new Evaluate();
            string input = "12 + 2";
            test.splitString(input);
            decimal actual = addTest.calculate(test.FirstNumber, test.Operator, test.SecondNumber);
            int expected = 14;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluateEnsureProperSubtractionOperation()
        {
            Parse test = new Parse();
            Evaluate subtractTest = new Evaluate();
            string input = "-2345 - -567";
            test.splitString(input);
            decimal actual = subtractTest.calculate(test.FirstNumber, test.Operator, test.SecondNumber);
            int expected = -1778;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluateEnsureProperMultiplicationOperation()
        {
            Parse test = new Parse();
            Evaluate multiplyTest = new Evaluate();
            string input = "-10 * 2";
            test.splitString(input);
            decimal actual = multiplyTest.calculate(test.FirstNumber, test.Operator, test.SecondNumber);
            int expected = -20;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluateEnsureProperDivisionOperation()
        {
            Parse test = new Parse();
            Evaluate divideTest = new Evaluate();
            string input = "5 / 2";
            test.splitString(input);
            decimal actual = divideTest.calculate(test.FirstNumber, test.Operator, test.SecondNumber);
            decimal expected = 2.50M;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluateEnsureProperModuloOperation()
        {
            Parse test = new Parse();
            Evaluate moduloTest = new Evaluate();
            string input = "24 % 5";
            test.splitString(input);
            decimal actual = moduloTest.calculate(test.FirstNumber, test.Operator, test.SecondNumber);
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }
    }
}
