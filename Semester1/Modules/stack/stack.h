#pragma once

struct StackElement;

struct Stack;

Stack *createStack();

void push(char value, Stack *stack);

char pop(Stack *stack);

void deleteStack(Stack *stack);

bool isEmpty(Stack *stack);

void printStack(Stack *stack);
