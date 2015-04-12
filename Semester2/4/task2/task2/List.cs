using System;

namespace ListNamespace
{
    /// <summary>
    /// List as a class
    /// </summary>
    public class List
    {
        private ListElement head;

        private ListElement tail;

        public int Size { get; private set; }

        /// <summary>
        /// Element of list
        /// </summary>
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

        /// <summary>
        /// Show all element of list
        /// </summary>
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

        /// <summary>
        /// Add new element of ascending
        /// </summary>
        /// <param name="value">element to be added in list</param>
        virtual public void AddInOrder(int value)
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
                {
                    current = current.Next;
                }
                newElement.Next = current.Next;
                current.Next = newElement;
            }
        }

        /// <summary>
        /// The element exists or not
        /// </summary>
        public bool Exists(int value)
        {
            if (IsEmpty())
            {
                return false;
            }
            ListElement auxilary = head;
            while (auxilary.Next != null && auxilary.Value != value)
            {
                auxilary = auxilary.Next;
            }
            return (auxilary.Value == value);
        }

        /// <summary>
        /// Remove element with a certain value
        /// </summary>
        /// <param name="value">Element to be deleted</param>
        virtual public void RemoveElement(int value)
        {
            if (IsEmpty())
            {
                return;
            }

            if (head.Value == value)
            {
                head = head.Next;
                Size--;
                return;
            }

            ListElement auxilary = head;
            while (auxilary.Next != null && auxilary.Next.Value != value)
            {
                auxilary = auxilary.Next;
            }

            if (auxilary.Next == null)
            {
                return;
            }

            auxilary.Next = auxilary.Next.Next;
            Size--;
            return;
        }

        public bool IsEmpty()
        {
            return (head == null);
        }

        /// <summary>
        /// Return value of the index
        /// </summary>
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
