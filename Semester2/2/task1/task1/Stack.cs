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
            int value = head.value;
            head = head.next;
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
                Console.Write(auxilary.value + " ");
                auxilary = auxilary.next;
            }
            Console.WriteLine();
        }

        private class StackElement
        {
            public StackElement(int value, StackElement next)
            {
                this.value = value;
                this.next = next;
            }

            public int value;
            public StackElement next;
        }

    }
    
}
