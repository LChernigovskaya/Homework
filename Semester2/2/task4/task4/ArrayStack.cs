using System;

namespace Task4
{
    //Stack based on array
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

        //Add new element
        public void Push(T value)
        {
            array[currentSize] = value;
            currentSize++;
        }

        //Print Stack
        public void PrintStack()
        {
            for (int i = 0; i < currentSize; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
            return;
        }

        //Return top element and remove it
        public T Pop()
        {
            if (IsEmpty())
                return default(T);
            T auxilary = array[currentSize - 1];
            currentSize--;
            return auxilary;
        }

        //Return top element
        public T Top()
        {
            if (IsEmpty())
                return default(T);
            return array[currentSize - 1];
        }

        //Stack is empty or not
        private bool IsEmpty()
        {
            return currentSize == 0;
        }
    }
}
