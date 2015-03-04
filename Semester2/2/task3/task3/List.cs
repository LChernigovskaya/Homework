using System;

namespace Task3
{
    /// <summary>
    /// List as a class
    /// </summary>
    class List
    {
        private ListElement head;

        private ListElement tail;

        public int Length { get; private set; }
        
        /// <summary>
        /// Element of list
        /// </summary>
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

        /// <summary>
        /// Show all elements of list
        /// </summary>
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

        /// <summary>
        /// Add new element
        /// </summary>
        /// <param name="value">Word to be added</param>
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

        /// <summary>
        /// Remove element with a certain value
        /// </summary>
        /// <param name="value">word to be deleted</param>
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

        /// <summary>
        /// Return value of the index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Such element is exist in list or not
        /// </summary>
        /// <param name="value">value to be checked</param>
        /// <returns></returns>
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
