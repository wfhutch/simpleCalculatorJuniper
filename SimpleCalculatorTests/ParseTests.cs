using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;
using System.Text;
using System.Collections.Generic;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class ParseTests
    {
        [TestMethod]
        public void ParseEnsureICanCreateAnInstance()
        {
            Parse test = new Parse();
        }

        [TestMethod]
        public void ParseEnsureICanAccessProperties()
        {
            Parse test = new Parse();
            test.FirstNumber = 1;
            test.SecondNumber = 2;
            int actual = test.FirstNumber + test.SecondNumber;
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ParseAddSpacesToUserInputIfEnteredWithoutThemTest1()
        {
            Parse test = new Parse();
            string input = "-510%-10";

            string actual = test.formatInput(input);
            string expected = "-510 % -10";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ParseAddSpacesToUserInputIfEnteredWithoutThemTest2()
        {
            Parse test = new Parse();
            string input = "100 /-4";

            string actual = test.formatInput(input);
            string expected = "100 / -4";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ParseEnsureExtractedNumbersSetAndGet()
        {
            Parse test = new Parse();
            string input = "1234 * 123";
            String[] actual = input.Split();
            int first;
            int second;

            Int32.TryParse(actual[0], out first);
            Int32.TryParse(actual[2], out second);
            string op = actual[1];
            test.FirstNumber = first;
            test.SecondNumber = second;
            test.Operator = op;

            Assert.AreEqual(1234, test.FirstNumber);
            Assert.AreEqual(123, test.SecondNumber);
            Assert.AreEqual("*", test.Operator);
        }

        [TestMethod]
        public void ParseEnsureICanSplitTheFormattedStringWithAMethod()
        {
            Parse test = new Parse();
            string input = "-20 / -30";
            test.splitString(input);
            Assert.AreEqual(-20, test.FirstNumber);
            Assert.AreEqual(-30, test.SecondNumber);
            Assert.AreEqual("/", test.Operator);


        }

        [TestMethod]
        public void ParseGetFormatStringUsingRegexTest2()
        {
            Parse test = new Parse();
            string str = "-9876 / - 45";
            string actual = test.formatInput(str);
            string expected = "Invalid Expression. Please try again!";
            Assert.AreEqual(expected, actual);
        }
    }
}
