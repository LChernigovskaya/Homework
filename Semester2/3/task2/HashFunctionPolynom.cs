using System;

namespace HashNamespace
{
    public class HashFunctionPolynom : HashTable
    {
        public HashFunctionPolynom(int maxSize)
            :base(maxSize)
        {
        }
        public override int HashFunction(string inputString)
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
    }
}
