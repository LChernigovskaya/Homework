using System;

namespace HashNamespace
{
    /// <summary>
    /// Implementation of the interface of hash-table
    /// </summary>
    public class HashTable : InterfaceHashTable
    {
        public delegate int HashFunction(string inputString, int maxSize);

        private int maxSize;
        private List[] hashTable;
        private HashFunction hashFunction = HashFunctionPolynom;

        public HashTable(int maxSize)
        {
            this.maxSize = maxSize;
            this.hashTable = new List[maxSize];
            for (int i = 0; i < maxSize; i++)
                hashTable[i] = new List();
        }

        public HashTable(int maxSize, HashFunction userHashFunction) : this(maxSize)
        {
            hashFunction = userHashFunction;
        }

        /// <summary>
        /// Hash function
        /// </summary>
        private static int HashFunctionPolynom(string inputString, int maxSize)
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
            int index = hashFunction(value, maxSize);
            hashTable[index].Add(value);
        }

        public void RemoveElement(string value)
        {
            int index = hashFunction(value, maxSize);
            hashTable[index].RemoveElement(value);
        }

        public bool IsExist(string value)
        {
            int index = hashFunction(value, maxSize);
            return hashTable[index].IsExist(value);
        }

        public void PrintList(string value)
        {
            int index = hashFunction(value, maxSize);
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
