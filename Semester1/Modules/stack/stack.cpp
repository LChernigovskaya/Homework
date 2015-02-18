#include <iostream>
#include "stack.h"

using namespace std;

struct StackElement
{
    char value;
    StackElement *next;
};

struct Stack
{
    StackElement *head;
};

Stack *createStack()
{
     Stack *stack = nullptr;
     stack = new Stack;
     stack->head = nullptr;
     return stack;
}

StackElement *createStackElement(char value)
{
    StackElement *stackElement = new StackElement;
    stackElement->next = nullptr;
    stackElement->value = value;
    return stackElement;
}

void push(char value, Stack *stack)
{
    if (stack->head == nullptr)
        stack->head = createStackElement(value);
    else
    {
        StackElement *auxilary = nullptr;
        auxilary = createStackElement(value);
        auxilary->next = stack->head;
        stack->head = auxilary;
    }
}

bool isEmpty(Stack *stack)
{
    return (stack->head == nullptr);
}

char pop(Stack *stack)
{
    char value = stack->head->value;
    StackElement *auxilary = stack->head;
    stack->head = stack->head->next;
    delete auxilary;
    return value;
}


void deleteStack(Stack *stack)
{
    while(stack->head != nullptr)
    {
        StackElement *auxilary = stack->head;
        stack->head = stack->head->next;
        delete auxilary;
    }
    delete stack;
}

void printStack(StackElement *stackElement)
{
    if (stackElement == nullptr)
        return;

    printStack(stackElement->next);
    cout << stackElement->value << " ";
}


void printStack(Stack *stack)
{
    if (stack->head == nullptr)
        return;
    else
    {
        printStack(stack->head);
        cout << endl;
    }
}
