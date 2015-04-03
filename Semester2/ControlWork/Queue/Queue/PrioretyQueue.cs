using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    /// <summary>
    /// Queue with priority
    /// </summary>
    public class PriorityQueue
    {
        private QueueElement head;
        private QueueElement tail;
        public int Size { get; set; }

        /// <summary>
        /// Element of queue
        /// </summary>
        class QueueElement
        {
            public QueueElement(int value, int key)
            {
                this.Value = value;
                this.Key = key;
                this.Next = null;
            }

            public int Value { get; set; }
            public int Key { get; set; }
            public QueueElement Next { get; set; }
        }

        /// <summary>
        /// Add in queue
        /// </summary>
        /// <param name="value">Value added element</param>
        /// <param name="key">Priority added element</param>
        public void Enqueue(int value, int key)
        {
            QueueElement newElement = new QueueElement(value, key);
            if (Size == 0)
            {
                head = newElement;
                tail = newElement;
                Size++;
            }

            else
            {
                Size++;

                if (head.Key < key)
                {
                    newElement.Next = head;
                    head = newElement;
                    return;
                }

                if (tail.Key >= key)
                {
                    tail.Next = newElement;
                    tail = newElement;
                    return;
                }

                QueueElement current = head;
                while (current.Next.Key >= key)
                    current = current.Next;
                newElement.Next = current.Next;
                current.Next = newElement;
            }
        }

        /// <summary>
        /// Return element with the highest priority and remove it
        /// </summary>
        /// <returns>Value of element with the highest priority</returns>
        public int Dequeue()
        {
            if (Size == 0)
                throw new Exception("Queue is empty");
            int result = head.Value;
            head = head.Next;
            return result;
        }

        /// <summary>
        /// Print Queue
        /// </summary>
        public void PrintQueue()
        {
            QueueElement auxilary = head;
            while (auxilary != null)
            {
                Console.Write(auxilary.Value + " ");
                auxilary = auxilary.Next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Check element exists or does not
        /// </summary>
        /// <param name="value">value checked element</param>
        /// <param name="key">priority checked element</param>
        /// <returns></returns>
        public bool Exists(int value, int key)
        {
            if (Size == 0)
                return default(bool);
            QueueElement auxilary = head;
            while (auxilary.Next != null && auxilary.Value != value)
                auxilary = auxilary.Next;
            while (auxilary.Next != null && auxilary.Key != key)
                auxilary = auxilary.Next;
            return (auxilary.Value == value);
        }

    }
}
