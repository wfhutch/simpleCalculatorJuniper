using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Parse userInput = new Parse();
            Evaluate expression = new Evaluate();
            Stack stack = new Stack();

            bool runProgram = true;
            int counter = 0;

            while (runProgram)
            {
                Console.Write("[" + counter + "]> ");

                string response = Console.ReadLine();

                if (response == "exit" || response == "quit")
                {
                    Console.WriteLine("Bye!!");
                    runProgram = false;
                    Console.ReadKey();
                }
                else if(response == "lastq")
                {
                    string last_expression = stack.LastExpression;
                    Console.WriteLine(last_expression);
                }
                else if (response == "last")
                {
                    decimal last_answer = stack.LastAnswer;
                    Console.WriteLine(last_answer);

                }
                else
                {
                    string splitResponse = userInput.formatInput(response);
                    if (splitResponse == "Invalid Expression. Please try again!")
                    {
                        Console.WriteLine(splitResponse);
                    }
                    else
                    {
                        userInput.splitString(splitResponse);
                        decimal user_answer =
                            expression.calculate(userInput.FirstNumber, userInput.Operator, userInput.SecondNumber);
                        counter += 1;
                        Console.WriteLine("   " + "=" + " " + user_answer);
                        stack.LastExpression = response;
                        stack.LastAnswer = user_answer;
                    }
                }
            }
        }
    }
}
