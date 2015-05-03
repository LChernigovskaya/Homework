#pragma once

#include <QtCore/QObject>
#include <QtTest/QtTest>

#include "arrayStack.h"
#include "linkedStack.h"
#include "calc.h"
#include "myException.h"

class CalcTest : public QObject
{
    Q_OBJECT

public:
    explicit CalcTest(QObject *parent = 0) : QObject(parent) {}

private slots:
    void init()
    {
        stack = new LinkedStack();
        calcTest = new StackCalc();
    }

    void cleanup()
    {
        delete stack;
        delete calcTest;
    }

    void easyExpressionTest()
    {
        QCOMPARE(calcTest->calculate("7 6.1 +", stack), 13.1);
    }

    void calculateTest()
    {
        QCOMPARE(calcTest->calculate("5 6 + 12 *", stack), 132.0);
    }

    void calculate2Test()
    {
        QCOMPARE(calcTest->calculate("552 60 9 + 4 * / 3.5 -", stack), -1.5);
    }

    void divisionByZeroTest()
    {
        try
        {
            calcTest->calculate("7 0 /", stack);
        }
        catch(MyException exc)
        {
            QCOMPARE(exc.errowString(), "Division by zero");
        }
    }

private:
    StackCalc *calcTest;
    Stack *stack;

};
