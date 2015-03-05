using System;

namespace Task1
{
    class Stack
    {

        private StackElement head;

        public void Push(int value)
        {
            StackElement newElement = new StackElement(value, head);
            head = newElement;
        }

        public int Pop()
        {
            int value = head.Value;
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
            public StackElement(int value, StackElement next)
            {
                this.Value = value;
                this.Next = next;
            }

            public int Value { get; set; }
            public StackElement Next { get; set; }
        }
    }
}
