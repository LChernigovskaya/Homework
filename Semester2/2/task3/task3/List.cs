using System;

namespace Task3
{
    // List as a class
    class List
    {
        private ListElement head;

        private ListElement tail;

        public int Length { get; private set; }

        // Element of list
        class ListElement
        {
            public ListElement(string value)
            {
                this.value = value;
                this.next = null;
                this.countRepetitions = 1;
            }

            public string value { get; set; }
            public ListElement next { get; set; }
            public int countRepetitions { get; set; }
        }

        // Show all element of list
        public void PrintList()
        {
            ListElement auxilary = head;
            while (auxilary != null)
            {
                Console.Write(auxilary.value + " (" + auxilary.countRepetitions + "repetitions) ");
                auxilary = auxilary.next;
            }
            Console.WriteLine();
        }

        // Add new element
        public void Add(string value)
        {
            if (head == null)
            {
                ListElement newElement = new ListElement(value);
                head = newElement;
                tail = newElement;
                Length++;
            }
            else
            {
                ListElement current = head;
                while (current.next != null && current.value != value)
                    current = current.next;
                if (current.value == value)
                    current.countRepetitions++;
                else
                {
                    Length++;
                    ListElement newElement = new ListElement(value);
                    tail.next = newElement;
                    tail = newElement;
                }
            }
        }

        // Remove element with a certain value
        public void RemoveElement(string value)
        {
            if (head == null)
                return;
            if (head.value == value)
            {
                if (head.countRepetitions != 1)
                    head.countRepetitions--;
                else
                {
                    Length--;
                    head = head.next;
                }
                return;
            }
            ListElement auxilary = head;
            while (auxilary.next != null && auxilary.next.value != value)
                auxilary = auxilary.next;
            if (auxilary.next == null)
                return;
            if (auxilary.next.countRepetitions != 1)
                auxilary.next.countRepetitions--;
            else
            {
                auxilary.next = auxilary.next.next;
                Length--;
            }
            return;
        }

        // Return value of the index
        public string ReturnValue(int index)
        {
            ListElement auxilary = head;
            while (index != 0)
            {
                auxilary = auxilary.next;
                index--;
            }
            return auxilary.value;
        }

        //Such element is exist in list or not
        public bool IsExist(string value)
        {
            if (head == null)
                return default(bool);
            ListElement auxilary = head;
            while (auxilary.next != null && auxilary.value != value)
                auxilary = auxilary.next;
            return (auxilary.value == value);
        }
    }
}
