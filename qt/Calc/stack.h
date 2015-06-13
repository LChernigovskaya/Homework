#pragma once

///Abstract class that realised stack
class Stack
{
public:
    ///Push element to the stack
    virtual void push(double value) = 0;

    ///Return top element from the stack and remove it
    virtual double pop() = 0;

    ///Return top element from the stack
    virtual double top() const = 0;

    ///Return size of the stack
    virtual int size() const = 0;

    ///Destructor for the stack
    virtual ~Stack() {}
};
