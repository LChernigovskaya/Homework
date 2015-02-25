using System;

namespace Task4
{
    //Stack based on links
    class LinkedStack<T> : InterfaceStack<T>
    {
        //Element of stack
        private class StackElement
        {
            public StackElement(T value, StackElement next)
            {
                this.value = value;
                this.next = next;
            }

            public T value { get; set; }
            public StackElement next { get; set; }
        }

        private StackElement head;

        //Add new element
        public void Push(T value)
        {
            StackElement newElement = new StackElement(value, head);
            head = newElement;
        }

        //Return top element and remove it
        public T Pop()
        {
            if (IsEmpty())
                return default(T);
            T value = head.value;
            head = head.next;
            return value;
        }

        //Return top element
        public T Top()
        {
            if (IsEmpty())
                return default(T);
            return head.value;
        }

        //Stack is empty or not
        private bool IsEmpty()
        {
            return (head == null);
        }

        //Print stack
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
    }
}
