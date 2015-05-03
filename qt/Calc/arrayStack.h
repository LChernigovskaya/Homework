#pragma once

#include "stack.h"

///Stack based on array
class ArrayStack : public Stack
{
public:
    ArrayStack(int maxSize);
    void push(double value);
    double pop();
    double top() const;
    int size() const;
    ~ArrayStack() override;

private:
    int mCurrent;
    double *mArray;
};


