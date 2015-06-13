#pragma once
#include"stack.h"
#include<QString>

///Class that realised stack calculator
class StackCalc
{
public:
    ///Calculate the expression using a certain stack
    double calculate(const QString &expression, Stack *stack);

private:
    ///This symbol is operation or not
    bool isOperation(char value) const;

    ///Perform the operation
    double calculateResult(char operation, double number1, double number2);

};
