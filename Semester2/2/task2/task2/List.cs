using System;

namespace Task2
{
    class List
    {
        private ListElement head;

        private ListElement tail;

        public int Size { get; private set; }

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

        public void RemoveElement(int value)
        {
            if (head == null)
                return;
            ListElement auxilary = head;
            while (auxilary.next != null && auxilary.next.value != value)
                auxilary = auxilary.next;
            if (auxilary.next == null)
                return;
            ListElement current = auxilary.next.next;
            auxilary.next = current;
        }

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
    }

    
}
