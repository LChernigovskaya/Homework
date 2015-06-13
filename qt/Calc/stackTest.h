#pragma once

#include <QtCore/QObject>
#include <QtTest/QtTest>

#include "arrayStack.h"
#include "linkedStack.h"
#include "myException.h"

class StackTest : public QObject
{
    Q_OBJECT

public:
    explicit StackTest(QObject *parent = 0) : QObject(parent) {}

private slots:
    void init()
    {
        arrayStack = new ArrayStack(60);
        linkedStack = new LinkedStack;
    }

    void cleanup()
    {
        delete arrayStack;
        delete linkedStack;
    }

    void emptyArrayStackTest()
    {
        QCOMPARE(arrayStack->size(), 0);
    }

    void emptyLinkedStackTest()
    {
        QCOMPARE(linkedStack->size(), 0);
    }

    void pushArrayStackTest()
    {
        arrayStack->push(6);
        QCOMPARE(arrayStack->size(), 1);
    }

    void pusLinkedStackTest()
    {
        linkedStack->push(7);
        QCOMPARE(linkedStack->size(), 1);
    }

    void pushSeveralElementsArrayStackTest()
    {
        arrayStack->push(1);
        arrayStack->push(9);
        arrayStack->push(0);
        QCOMPARE(arrayStack->size(), 3);
    }

    void pushSeveralElementsLinkedStackTest()
    {
        linkedStack->push(7);
        linkedStack->push(11);
        linkedStack->push(0.8);
        QCOMPARE(linkedStack->size(), 3);
    }

    void popFromArrayStackTest()
    {
        arrayStack->push(7);
        QCOMPARE(arrayStack->pop(), 7.0);
        QCOMPARE(arrayStack->size(), 0);
    }

    void popFromLinkedStackTest()
    {
        linkedStack->push(9.7);
        QCOMPARE(linkedStack->pop(), 9.7);
        QCOMPARE(linkedStack->size(), 0);
    }

    void popSeveralElementsFromArrayStackTest()
    {
        arrayStack->push(4.3);
        arrayStack->push(4);
        arrayStack->push(66.5);
        QCOMPARE(arrayStack->pop(), 66.5);
        QCOMPARE(arrayStack->size(), 2);
        QCOMPARE(arrayStack->pop(), 4.0);
        QCOMPARE(arrayStack->size(), 1);
        QCOMPARE(arrayStack->pop(), 4.3);
        QCOMPARE(arrayStack->size(), 0);
    }

    void popSeveralElementsFromLinkedStackTest()
    {
        linkedStack->push(4.3);
        linkedStack->push(4);
        linkedStack->push(66);
        QCOMPARE(linkedStack->pop(), 66.0);
        QCOMPARE(linkedStack->size(), 2);
        QCOMPARE(linkedStack->pop(), 4.0);
        QCOMPARE(linkedStack->size(), 1);
        QCOMPARE(linkedStack->pop(), 4.3);
        QCOMPARE(linkedStack->size(), 0);
    }

    void emptyStackExceptionTest()
    {
        try
        {
            linkedStack->pop();
        }
        catch(MyException exc)
        {
            QCOMPARE(exc.message(), "Stack is empty");
        }
    }

private:
    ArrayStack *arrayStack;
    LinkedStack *linkedStack;
};
