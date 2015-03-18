using System;

namespace ListNamespace
{
    /// <summary>
    /// List as a class
    /// </summary>
    public class List<T>
    {
        private ListElement<T> head;

        private ListElement<T> tail;

        public int Size { get; private set; }

        /// <summary>
        /// Element of list
        /// </summary>
        class ListElement<T>
        {
            public ListElement(T value)
            {
                this.Value = value;
                this.Next = null;
            }

            public T Value { get; set; }
            public ListElement<T> Next { get; set; }
        }

        /// <summary>
        /// Show all element of list
        /// </summary>
        public void PrintList()
        {
            ListElement<T> auxilary = head;
            while (auxilary != null)
            {
                Console.Write(auxilary.Value + " ");
                auxilary = auxilary.Next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Add new element to the end of the list
        /// </summary>
        /// <param name="value">Value to be added</param>
        public void AddTail(T value)
        {
            ListElement<T> newElement = new ListElement<T>(value);
            if (Size == 0)
            {
                head = newElement;
                tail = newElement;
                Size++;
            }
            else
            {
                Size++;
                tail.Next = newElement;
                tail = newElement;
            }
            return;
        }

        /// <summary>
        /// Return value of the index
        /// </summary>
        public T ReturnValue(int index)
        {
            if (head == null)
                throw new ListException("Empty list");
            ListElement<T> auxilary = head;
            while (index != 0)
            {
                if (auxilary == null)
                    throw new ListException("Number of elements in list less than index");
                auxilary = auxilary.Next;
                index--;
            }
            return auxilary.Value;
        }
    }
}
