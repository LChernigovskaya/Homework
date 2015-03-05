using System;

namespace Task4
{
    /// <summary>
    /// Stack based on links
    /// </summary>
    class LinkedStack<T> : InterfaceStack<T>
    {
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

        private StackElement head;

        public void Push(T value)
        {
            StackElement newElement = new StackElement(value, head);
            head = newElement;
        }

        public T Pop()
        {
            if (IsEmpty())
                return default(T);
            T value = head.Value;
            head = head.Next;
            return value;
        }

        public T Top()
        {
            if (IsEmpty())
                return default(T);
            return head.Value;
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
    }
}
