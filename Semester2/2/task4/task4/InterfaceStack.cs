using System;

namespace Task4
{
    interface InterfaceStack<T>
    {
        void Push(T value);
        T Pop();
        void PrintStack();
        T Top();
    }
}
