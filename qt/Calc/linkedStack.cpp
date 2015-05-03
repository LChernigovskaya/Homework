#include "linkedStack.h"
#include "myException.h"

LinkedStack::LinkedStack() :
    head(nullptr)
  , currentSize(0)
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
    auxilary->next = head;
    auxilary->value = value;
    head = auxilary;
    currentSize++;
}

double LinkedStack::pop()
{
    if(size() == 0)
    {
        throw MyException("Stack is empty");
    }

    currentSize--;
    double result = head->value;
    StackElement *auxilary = head;
    head = head->next;
    delete auxilary;
    return result;
}

double LinkedStack::top() const
{
    return head->value;
}

int LinkedStack::size() const
{
    return currentSize;
}

LinkedStack::~LinkedStack()
{
    while(head != nullptr)
    {
        StackElement *auxilary = head;
        head = head->next;
        delete auxilary;
    }
    delete head;
}
