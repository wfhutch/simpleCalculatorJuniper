using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Parse
    {
        public int FirstNumber { get; set; }
        public string Operator { get; set; }
        public int SecondNumber { get; set; }

        // This method formats the user input to add spaces before and after the operator.
        // If the use enters 6*7 this method will return 6 * 7.
        public string formatInput(string input)
        {
            string newInput = "";
            var firstNumber = Regex.Match(input, @"-?\d+");
            var opSign = Regex.Match(input, @"(?!^)([-+*/%])");
            var secondNumber = Regex.Match(input, @"(?<!\d)(-?\d+$)");

            if (input.Replace(" ", "").Length != firstNumber.Length + opSign.Length + secondNumber.Length)
            {
                newInput = "Invalid Expression. Please try again!";
                
            } else
            {
                newInput = (firstNumber + " " + opSign + " " + secondNumber);
                //splitString(newInput);
            }
                return newInput;
        }

        // This method splits the formatted user input into a string array.
        // Input string "1 + 2" becomes string array "1", "+", "2".
        // Property value is then set for each element in the array.
        public void splitString(string input)
        {
            String[] substrings = input.Split();
            {
            int first;
            int second;

            Int32.TryParse(substrings[0], out first);
            FirstNumber = first;

            Int32.TryParse(substrings[2], out second);
            SecondNumber = second;

            string op = substrings[1];
            Operator = op;
            //return substrings;
            }
        }

    }
}
