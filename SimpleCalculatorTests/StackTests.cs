using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
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
    }
}
