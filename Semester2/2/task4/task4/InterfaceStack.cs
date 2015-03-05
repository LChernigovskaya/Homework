using System;

namespace Task4
{
    /// <summary>
    /// Stack
    /// </summary>
    interface InterfaceStack<T>
    {
        /// <summary>
        /// Push value to a stack
        /// </summary>
        /// <param name="value">Value to be pushed</param>
        void Push(T value);

        /// <summary>
        /// Return top element and remove it
        /// </summary>
        T Pop();

        /// <summary>
        /// Show all elements in stack
        /// </summary>
        void PrintStack();

        /// <summary>
        /// Return top element
        /// </summary>
        T Top();

        /// <summary>
        /// Stack is empty or not
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
    }
}
