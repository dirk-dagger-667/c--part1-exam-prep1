using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputExpression = "4+6/5+(4*9-8)/7*2";
            double? firstOperandOut = null;
            double? secondOperandOut = null;
            string operatorEnteredIn = "";
            string operatorEnteredOut = "";
            string currentSymbol = "";
            bool inBrackets = false;
            double? firstOperandIn = null;
            double? secondOperandIn = null;

            for (int i = 0; i < inputExpression.Length; i++)
            {

                currentSymbol = inputExpression[i].ToString();

                if (currentSymbol == "0" || currentSymbol == "1" || currentSymbol == "2" || currentSymbol == "3" || currentSymbol == "4" || 
                    currentSymbol == "5" || currentSymbol == "6" || currentSymbol == "7" || currentSymbol == "8" || currentSymbol == "9")
                {
                    if (firstOperandOut == null && inBrackets == false)
                    {
                        firstOperandOut = double.Parse(inputExpression[i].ToString());
                    }
                    else if(firstOperandOut != null && inBrackets == false)
                    {
                        secondOperandOut = double.Parse(inputExpression[i].ToString());
                    }
                    else if (inBrackets == true && firstOperandIn == null)
	                {
                        firstOperandIn = double.Parse(inputExpression[i].ToString());
	                }
                    else if (inBrackets == true && firstOperandIn != null)
                    {
                        secondOperandIn = double.Parse(inputExpression[i].ToString());
                    }
                }
                else if (currentSymbol == "+" || currentSymbol == "-" || currentSymbol == "*" || currentSymbol == "/")
                {
                    if (inBrackets == true)
                    {
                        operatorEnteredIn = currentSymbol;
                    }
                    else
                    {
                        operatorEnteredOut = currentSymbol;
                    }
                }
                else if (currentSymbol == "(")
                {
                    inBrackets = true;
                }
                else if (currentSymbol == ")")
                {
                    inBrackets = false;

                    if (firstOperandOut == null)
                    {
                        firstOperandOut = firstOperandIn;
                    }
                    else
                    {
                        secondOperandOut = firstOperandIn;
                    }

                    firstOperandIn = null;
                    secondOperandIn = null;
                }

                if (firstOperandOut != null && secondOperandOut != null && operatorEnteredOut != "" && inBrackets == false)
                {
                    switch (operatorEnteredOut)
                    {
                        case "+":
                            firstOperandOut = firstOperandOut + secondOperandOut;
                            break;
                        case "-":
                            firstOperandOut = firstOperandOut - secondOperandOut;
                            break;
                        case "*":
                            firstOperandOut = firstOperandOut * secondOperandOut;
                            break;
                        case "/":
                            firstOperandOut = firstOperandOut / secondOperandOut;
                            break;
                    }

                    secondOperandOut = null;
                    operatorEnteredOut = "";
                }
                else if(firstOperandIn != null && secondOperandIn != null && operatorEnteredIn != "" && inBrackets == true)
                {
                    switch (operatorEnteredIn)
                    {
                        case "+":
                            firstOperandIn = firstOperandIn + secondOperandIn;
                            break;
                        case "-":
                            firstOperandIn = firstOperandIn - secondOperandIn;
                            break;
                        case "*":
                            firstOperandIn = firstOperandIn * secondOperandIn;
                            break;
                        case "/":
                            firstOperandIn = firstOperandIn / secondOperandIn;
                            break;
                    }

                    secondOperandIn = null;
                    operatorEnteredIn = "";
                }

            }

            Console.WriteLine(firstOperandOut);

        }
    }
}
