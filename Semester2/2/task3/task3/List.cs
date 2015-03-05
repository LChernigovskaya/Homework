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
                this.Value = value;
                this.Next = null;
                this.CountRepetitions = 1;
            }

            public string Value { get; set; }
            public ListElement Next { get; set; }
            public int CountRepetitions { get; set; }
        }

        /// <summary>
        /// Show all elements of list
        /// </summary>
        public void PrintList()
        {
            ListElement auxilary = head;
            while (auxilary != null)
            {
                Console.Write(auxilary.Value + " (" + auxilary.CountRepetitions + "repetitions) ");
                auxilary = auxilary.Next;
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
                while (current.Next != null && current.Value != value)
                    current = current.Next;
                if (current.Value == value)
                    current.CountRepetitions++;
                else
                {
                    Length++;
                    ListElement newElement = new ListElement(value);
                    tail.Next = newElement;
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
            if (head.Value == value)
            {
                if (head.CountRepetitions != 1)
                    head.CountRepetitions--;
                else
                {
                    Length--;
                    head = head.Next;
                }
                return;
            }
            ListElement auxilary = head;
            while (auxilary.Next != null && auxilary.Next.Value != value)
                auxilary = auxilary.Next;
            if (auxilary.Next == null)
                return;
            if (auxilary.Next.CountRepetitions != 1)
                auxilary.Next.CountRepetitions--;
            else
            {
                auxilary.Next = auxilary.Next.Next;
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
                auxilary = auxilary.Next;
                index--;
            }
            return auxilary.Value;
        }

        /// <summary>
        /// Such element is exist in list or not
        /// </summary>
        /// <param name="value">value to be checked</param>
        /// <returns></returns>
        public bool Exists(string value)
        {
            if (head == null)
                return default(bool);
            ListElement auxilary = head;
            while (auxilary.Next != null && auxilary.Value != value)
                auxilary = auxilary.Next;
            return (auxilary.Value == value);
        }
    }
}
