using System;
using System.Collections.Generic;
using System.Collections;

namespace ListNamespace
{
    /// <summary>
    /// List as a class
    /// </summary>
    public class MyList<T> : IEnumerable, IEnumerator
    {
        private ListElement head;

        private int position = -1;

        public int Length { get; private set; }
        
        /// <summary>
        /// Element of list
        /// </summary>
        class ListElement
        {
            public ListElement(T value)
            {
                this.Value = value;
                this.Next = null;
            }

            public T Value { get; set; }
            public ListElement Next { get; set; }
        }

        /// <summary>
        /// Show all elements of list
        /// </summary>
        public string PrintList()
        {
            string result = null;
            foreach (ListElement element in this)
            {
                result += element.Value.ToString() + " ";
            }
            Reset();
            return result;
        }

        /// <summary>
        /// Add new element to head of list
        /// </summary>
        /// <param name="value">Element to be added</param>
        public void AddToHead(T value)
        {
            ListElement newElement = new ListElement(value);
            newElement.Next = head;
            head = newElement;

            Length++;
        }

        /// <summary>
        /// Add new element according to position
        /// </summary>
        /// <param name="value">element to be added</param>
        /// <param name="position">position</param>
        public void AddToPosition(T value, int position)
        {
            if (position > Length)
                throw new Exception("Number of elements less than position");
            if (position == 0)
            {
                AddToHead(value);
                return;
            }

            ListElement auxilary = head;
            ListElement current = auxilary;

            int i = 0;
            while (i < position)
            {
                current = auxilary;
                auxilary = auxilary.Next;
                i++;
            }

            ListElement newElement = new ListElement(value);
            newElement.Next = auxilary;
            current.Next = newElement;
            Length++;
            return;
        }

        /// <summary>
        /// Remove element with a certain value
        /// </summary>
        /// <param name="value">word to be deleted</param>
        public void RemoveElement(T value)
        {
            if (!Exists(value))
                throw new Exception("Such element doesn't exist already");

            if (Equals(head.Value, value))
            {
                Length--;
                head = head.Next;
                return;
            }

            ListElement auxilary = head;
            while (!Equals(auxilary.Next.Value, value))
            {
                auxilary = auxilary.Next;
            }

            auxilary.Next = auxilary.Next.Next;
            Length--;

            return;
        }

        /// <summary>
        /// Return value of the index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T ReturnValue(int index)
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
        public bool Exists(T value)
        {
            if (head == null)
                return false;
            ListElement auxilary = head;
            while (auxilary.Next != null && !Equals(auxilary.Value, value))
            {
                auxilary = auxilary.Next;
            }
            return (Equals(auxilary.Value, value));
        }

        /// <summary>
        /// Reilized for IEnumerable and IEnumerator
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return (ElementInPosition(position)); }
        }

        public bool MoveNext()
        {
            position++;
            return !(ElementInPosition(position) == null);
        }

        private ListElement ElementInPosition(int position)
        {
            var auxilary = head;
            for (int i = 0; i < position && auxilary != null; i++)
                auxilary = auxilary.Next;
            return auxilary;
        }
    }
}
