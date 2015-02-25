using System;

namespace Task4
{
    //StackCalculator
    class Calc
    {
        public Calc(InterfaceStack<double> stack)
        {
            this.stackCalc = stack;
        }

        private InterfaceStack<double> stackCalc;

        //Perform the operation
        private double CalculateResult(char operation)
        {
            double number2 = stackCalc.Pop();
            double number1 = stackCalc.Pop();
            if (operation == '+')
                return number1 + number2;
            if (operation == '-')
                return number1 - number2;
            if (operation == '*')
                return number1 * number2;
            if (operation == '/' && number2 != 0)
                return number1 / number2;
            return default(int);
        }

        private bool IsOperation(string inputString)
        {
            return (inputString == "+" || inputString == "-" || inputString == "*" || inputString == "/");
        }

        //Get numbers and operation, calculate and add result in stack
        public void Calculate(string inputString)
        {
            if (IsOperation(inputString))
            {
                double result = CalculateResult(Convert.ToChar(inputString));
                stackCalc.Push(result);
                return;
            }
            else
            {
                stackCalc.Push(Convert.ToDouble(inputString));
            }
        }

        //show the result of last operation
        public double ShowResult()
        {
            return stackCalc.Top();
        }
    }
}
