using System;

namespace HashNamespace
{
    /// <summary>
    /// Implementation of the interface of hash-table
    /// </summary>
    public abstract class HashTable : InterfaceHashTable
    {
        public HashTable(int maxSize)
        {
            this.maxSize = maxSize;
            this.hashTable = new List[maxSize];
            for (int i = 0; i < maxSize; i++)
                hashTable[i] = new List();
        }

        protected int maxSize;
        private List[] hashTable;

        /// <summary>
        /// hash function
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>Index of input string in hash table</returns>
        public abstract int HashFunction(string inputString);

        public void AddElement(string value)
        {
            int index = HashFunction(value);
            hashTable[index].Add(value);
        }

        public void RemoveElement(string value)
        {
            int index = HashFunction(value);
            hashTable[index].RemoveElement(value);
        }

        public bool IsExist(string value)
        {
            int index = HashFunction(value);
            return hashTable[index].IsExist(value);
        }

        public void PrintList(string value)
        {
            int index = HashFunction(value);
            hashTable[index].PrintList();
        }

        public void PrintStatistic()
        {
            int numberOfElements = 0;
            double average = 0;
            int emptyCells = 0;
            int maxLengthIndex = 0;
            for (int i = 0; i < maxSize; i++)
            {
                numberOfElements = numberOfElements + hashTable[i].Length;
                if (hashTable[i].Length == 0)
                    emptyCells++;
                if (hashTable[maxLengthIndex].Length < hashTable[i].Length)
                    maxLengthIndex = i;
            }
            average = (double)numberOfElements / (double)maxSize;
            Console.WriteLine("Words: " + numberOfElements);
            Console.WriteLine("Average length: " + average);
            Console.WriteLine("Empty cells: " + emptyCells);

            int maxLength = hashTable[maxLengthIndex].Length;
            Console.WriteLine("Max chains:");
            for (int i = 0; i < maxSize; i++)
                if (hashTable[i].Length == maxLength)
                {
                    hashTable[i].PrintList();
                    Console.WriteLine();
                }
        }
    }
}
