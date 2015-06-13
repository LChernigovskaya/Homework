#include "linkedStack.h"
#include "myException.h"

LinkedStack::LinkedStack() :
    mHead(nullptr)
  , mCurrentSize(0)
{
}

struct LinkedStack::StackElement
{
    double value;
    StackElement *next;
};

void LinkedStack::push(double value)
{
    StackElement *auxilary = new StackElement;
    auxilary->next = mHead;
    auxilary->value = value;
    mHead = auxilary;
    mCurrentSize++;
}

double LinkedStack::pop()
{
    if(size() == 0)
    {
        throw MyException("Stack is empty");
    }

    mCurrentSize--;
    double result = mHead->value;
    StackElement *auxilary = mHead;
    mHead = mHead->next;
    delete auxilary;
    return result;
}

double LinkedStack::top() const
{
    return mHead->value;
}

int LinkedStack::size() const
{
    return mCurrentSize;
}

LinkedStack::~LinkedStack()
{
    while(mHead != nullptr)
    {
        StackElement *auxilary = mHead;
        mHead = mHead->next;
        delete auxilary;
    }
    delete mHead;
}
