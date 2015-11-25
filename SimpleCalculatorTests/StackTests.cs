using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void StackEnsureICanCreateAClassInstance()
        {
            Stack test = new Stack();
            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void StackEnsureGettersAndSettersWork()
        {
            Stack test = new Stack();
            decimal number = 5;
            test.LastAnswer = number;
            string expression = "1+2";
            test.LastExpression = expression;
            string expected_expression = test.LastExpression;
            decimal expected_number = test.LastAnswer;
            Assert.AreEqual(expected_expression, expression);
            Assert.AreEqual(expected_number, number);
        }
    }
}
