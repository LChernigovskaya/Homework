using System;

namespace Task4
{
    /// <summary>
    /// Stack based on array
    /// </summary>
    class ArrayStack<T> : InterfaceStack<T> 
    {
        public ArrayStack(int maxSize)
        {
            this.currentSize = 0;
            this.maxSize = maxSize;
            this.array = new T[maxSize];
        }
        
        private int maxSize;
        private int currentSize;
        private T[] array;

        public void Push(T value)
        {
            array[currentSize] = value;
            currentSize++;
        }

        public void PrintStack()
        {
            for (int i = 0; i < currentSize; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
            return;
        }

        public T Pop()
        {
            if (IsEmpty())
                return default(T);
            T auxilary = array[currentSize - 1];
            currentSize--;
            return auxilary;
        }

        public T Top()
        {
            if (IsEmpty())
                return default(T);
            return array[currentSize - 1];
        }

        public bool IsEmpty()
        {
            return currentSize == 0;
        }
    }
}
