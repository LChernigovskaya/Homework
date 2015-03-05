using System;

namespace HashNamespace
{
    public class HashFunctionSum : HashTable
    {
        public HashFunctionSum(int maxSize)
            : base(maxSize)
        {
        }

        public override int HashFunction(string inputString)
        {
            int hashf = 0;
            int length = inputString.Length;

            for (int i = 0; i < length; i++)
                hashf += inputString[i];

            return hashf % maxSize;
        }
    }
}
