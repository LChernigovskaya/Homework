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
                this.value = value;
                this.next = null;
            }

            public int value { get; set; }
            public ListElement next { get; set; }
        }

        // Show all element of list
        public void PrintList()
        {
            ListElement auxilary = head;
            while (auxilary != null)
            {
                Console.Write(auxilary.value + " ");
                auxilary = auxilary.next;
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
                if (head.value >= value)
                {
                    newElement.next = head;
                    head = newElement;
                    return;
                }

                if (tail.value <= value)
                {
                    tail.next = newElement;
                    tail = newElement;
                    return;
                }

                ListElement current = head;
                while (current.next.value < value)
                    current = current.next;
                newElement.next = current.next;
                current.next = newElement;
            }
        }

        // Remove element with a certain value
        public void RemoveElement(int value)
        {
            if (head == null)
                return;
            if (head.value == value)
                head = head.next;
            ListElement auxilary = head;
            while (auxilary.next != null && auxilary.next.value != value)
                auxilary = auxilary.next;
            if (auxilary.next == null)
                return;
            auxilary.next = auxilary.next.next;
            return;
        }

        // Return value of the index
        public int ReturnValue(int index)
        {
            ListElement auxilary = head;
            while (index != 0)
            {
                auxilary = auxilary.next;
                index--;
            }
            return auxilary.value;
        }
    }
}
