using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;
using System.Collections.Generic;

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

        [TestMethod]
        public void StackEnsureICanAddKeysAndValuesToTheDictionary()
        {
            Stack test = new Stack();
            string user_key = "x";
            int user_value = 27;
            test.AddVariables(user_key, user_value);
            List<string> expected = test.FindAllKeysAndValues();
            Assert.AreEqual(expected, "x=27");

        }
    }
}
