using System;

namespace Task3
{
    /// <summary>
    /// Implementation of the interface of hash-table
    /// </summary>
    class HashTable : InterfaceHashTable
    {
        public HashTable(int maxSize)
        {
            this.maxSize = maxSize;
            this.hashTable = new List[maxSize];
            for (int i = 0; i < maxSize; i++)
                hashTable[i] = new List();
        }

        private int maxSize;
        private List[] hashTable;

        /// <summary>
        /// hash function
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>Index of input string in hash table</returns>
        private int Hash(string inputString)
        {
            int primeNumber = 67;
            int degree = 1;
            int length = inputString.Length;
            int result = 0;
            for (int i = 0; i < length; i++)
            {
                result = ((inputString[i] * degree) % maxSize + result) % maxSize;
                degree = (degree * primeNumber) % maxSize;
            }
            return result;
        }

        public void AddElement(string value)
        {
            int index = Hash(value);
            hashTable[index].Add(value);
        }

        public void RemoveElement(string value)
        {
            int index = Hash(value);
            hashTable[index].RemoveElement(value);
        }

        public bool Exists(string value)
        {
            int index = Hash(value);
            return hashTable[index].Exists(value);
        }

        public void PrintList(string value)
        {
            int index = Hash(value);
            hashTable[index].PrintList();
        }

        public void PrintStatistic()
        {
            int numberOfElements = 0;
            double average = 0;
            int emptyCells = 0;
            for (int i = 0; i < maxSize; i++)
            {
                numberOfElements = numberOfElements + hashTable[i].Length;
                average = (double)numberOfElements / (double)maxSize;
                if (hashTable[i].Length == 0)
                    emptyCells++;
            }
            Console.WriteLine("Number of words in hash-table: " + numberOfElements);
            Console.WriteLine("Average length: " + average);
            Console.WriteLine("Empty cells: " + emptyCells);
        }
    }
}
