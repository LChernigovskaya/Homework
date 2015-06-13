#pragma once

#include "stack.h"

///Stack based on links
class LinkedStack : public Stack
{
public:
    LinkedStack();
    void push(double value);
    double pop();
    double top() const;
    int size() const;
    ~LinkedStack() override;

private:
    struct StackElement;
    StackElement *mHead;
    int mCurrentSize;
};
