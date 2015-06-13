#include "arrayStack.h"
#include "myException.h"

ArrayStack::ArrayStack(int maxSize) :
    mCurrent(0)
  , mArray(new double[maxSize])
{
}

void ArrayStack::push(double value)
{
    mArray[mCurrent] = value;
    mCurrent++;
}

double ArrayStack::pop()
{
    if (size() == 0)
    {
        throw MyException("Stack is empty");
    }

    mCurrent--;
    return mArray[mCurrent + 1];
}

double ArrayStack::top() const
{
    return mArray[mCurrent];
}

int ArrayStack::size() const
{
    return mCurrent;
}

ArrayStack::~ArrayStack()
{
    mCurrent = 0;
    delete []mArray;
}
