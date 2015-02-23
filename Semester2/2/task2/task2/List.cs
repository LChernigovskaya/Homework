using System;

namespace Task2
{
    class List
    {
        private ListElement head;

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

        public int Size()
        {
            int count = 0;
            ListElement auxilary = head;
            while (auxilary != null)
            {
                count++;
                auxilary = auxilary.next;
            }

            return count;
        }
   
        private void AddHead(int value)
        {
            ListElement newElement = new ListElement(value, head);
            newElement.next = head;
            head = newElement;
        }

        private void AddTail(int value)
        {
            if (head == null)
            {
                head = new ListElement(value, null);
                return;
            }

            ListElement auxilary = head;
            while (auxilary.next != null)
                auxilary = auxilary.next;
            auxilary.next = new ListElement(value, null);
        }

        public void AddInOrder(int value)
        {
            if (head == null)
                head = new ListElement(value, null);

            else
            {
                ListElement current = head;
                if (current.value >= value)
                {
                    AddHead(value);
                    return;
                }

                while (current.next != null && current.next.value < value)
                    current = current.next;
                if (current.next == null)
                {
                    AddTail(value);
                    return;
                }
                else
                {
                    ListElement auxilary = new ListElement(value, null);
                    auxilary.next = current.next;
                    current.next = auxilary;
                }
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
            public ListElement(int value, ListElement next)
            {
                this.value = value;
                this.next = next;
            }

            public int value;
            public ListElement next;
        }
    }

    
}
