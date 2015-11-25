using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SimpleCalculator
{
    public class Evaluate
    {
        Parse userInput = new Parse();
        decimal answer = 0;

        public decimal calculate(int first, string op, int second)
        {
            if (op == "+")
            {
                answer = first + second;
            }
            else if (op == "-")
            {
                answer = first - second;
            }
            else if (op == "*")
            {
                answer = first * second;
            }
            else if (op == "/")
            {
                answer = decimal.Round(Convert.ToDecimal(first) / Convert.ToDecimal(second), 2);
            }
            else if (op == "%")
            {
                answer = first % second;
            }
            return answer;
        }
    }
}
