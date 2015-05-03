#include "calc.h"
#include "myException.h"

double StackCalc::calculate(QString expression, Stack *stack)
{
    int currentPosition = 0;
    int length = expression.length();
    while (currentPosition < length)
    {
        if(isOperation(expression[currentPosition].toLatin1()))
        {
            char operation = expression[currentPosition].toLatin1();
            double number2 = stack->pop();
            double number1 = stack->pop();
            double result = calculateResult(operation, number1, number2);
            stack->push(result);
            currentPosition++;
        }

        else
        {
            QString number = "";
            while(currentPosition < length && expression[currentPosition] != ' ')
            {
                number += expression[currentPosition].toLatin1();
                currentPosition++;
            }
            stack->push(number.toDouble());
        }
        currentPosition++;
    }
    return stack->top();
}

bool StackCalc::isOperation(char value) const
{
    return (value == '+' || value == '-' || value == '*' || value == '/');
}

double StackCalc::calculateResult(char operation, double number1, double number2)
{
    if(operation == '+')
    {
        return number1 + number2;
    }

    else if(operation == '-')
    {
        return number1 - number2;
    }

    else if(operation == '*')
    {
        return number1 * number2;
    }

    else
    {
        if (number2 == 0)
        {
            throw MyException("Division by zero");
        }
        return number1 / number2;
    }
}
