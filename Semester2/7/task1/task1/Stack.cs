using System;
using System.Collections.Generic;

namespace StackNamespace
{
    public class Stack<T>
    {
        private StackElement head;

        public Stack()
        {
            head = null;
        }

        /// <summary>
        /// Push element to the stack
        /// </summary>
        /// <param name="value">Element to be pushed</param>
        public void Push(T value)
        {
            StackElement newElement = new StackElement(value, head);
            head = newElement;
        }

        /// <summary>
        /// Remove elment from the stack
        /// </summary>
        /// <returns>Value of the removed element</returns>
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty");
            }
            T value = head.Value;
            head = head.Next;
            return value;
        }

        /// <summary>
        /// Stack is empty or not
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return (head == null);
        }

        /// <summary>
        /// Print all elements of the stack
        /// </summary>
        public void PrintStack()
        {
            StackElement auxilary = head;
            while (auxilary != null)
            {
                Console.Write(auxilary.Value + " ");
                auxilary = auxilary.Next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Element of thee stack
        /// </summary>
        private class StackElement
        {
            public StackElement(T value, StackElement next)
            {
                this.Value = value;
                this.Next = next;
            }

            public T Value { get; set; }
            public StackElement Next { get; set; }
        }
    }
}