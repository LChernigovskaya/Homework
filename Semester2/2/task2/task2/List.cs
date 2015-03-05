using System;

namespace Task2
{
    // List as a class
    class List
    {
        private ListElement head;

        private ListElement tail;

        public int Size { get; private set; }

        // Element of list
        class ListElement
        {
            public ListElement(int value)
            {
                this.Value = value;
                this.Next = null;
            }

            public int Value { get; set; }
            public ListElement Next { get; set; }
        }

        // Show all element of list
        public void PrintList()
        {
            ListElement auxilary = head;
            while (auxilary != null)
            {
                Console.Write(auxilary.Value + " ");
                auxilary = auxilary.Next;
            }
            Console.WriteLine();
        }

        // Add new element of ascending
        public void AddInOrder(int value)
        {
            ListElement newElement = new ListElement(value);
            if (Size == 0)
            {
                head = newElement;
                tail = newElement;
                Size++;
            }
            else
            {
                Size++;
                if (head.Value >= value)
                {
                    newElement.Next = head;
                    head = newElement;
                    return;
                }

                if (tail.Value <= value)
                {
                    tail.Next = newElement;
                    tail = newElement;
                    return;
                }

                ListElement current = head;
                while (current.Next.Value < value)
                    current = current.Next;
                newElement.Next = current.Next;
                current.Next = newElement;
            }
        }

        // Remove element with a certain value
        public void RemoveElement(int value)
        {
            if (head == null)
                return;
            if (head.Value == value)
            {
                head = head.Next;
                Size--;
                return;
            }
            ListElement auxilary = head;
            while (auxilary.Next != null && auxilary.Next.Value != value)
                auxilary = auxilary.Next;
            if (auxilary.Next == null)
                return;
            auxilary.Next = auxilary.Next.Next;
            Size--;
            return;
        }

        // Return value of the index
        public int ReturnValue(int index)
        {
            ListElement auxilary = head;
            while (index != 0)
            {
                auxilary = auxilary.Next;
                index--;
            }
            return auxilary.Value;
        }
    }
}
