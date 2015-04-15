using System;
using System.Collections.Generic;

namespace StackNamespace
{
    public class Stack<T>
    {
        private StackElement head;

        public void Push(T value)
        {
            StackElement newElement = new StackElement(value, head);
            head = newElement;
        }

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

        public bool IsEmpty()
        {
            return (head == null);
        }

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