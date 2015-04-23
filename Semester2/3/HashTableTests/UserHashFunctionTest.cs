using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashNamespace;

namespace HashTableTests
{
    [TestClass]
    public class UserHashFunctionTest
    {
        private HashTable hash;

        private int UserHashFunction(string inputString, int maxSize)
        {
            int hashf = 0;
            int length = inputString.Length;

            for (int i = 0; i < length; i++)
                hashf += inputString[i];

            return hashf % maxSize;
        }

        [TestInitialize]
        public void Initialize()
        {
            hash = new HashTable(97, UserHashFunction);
        }

        [TestMethod]
        public void AddTest()
        {
            hash.AddElement("hello");
            Assert.IsTrue(hash.IsExist("hello"));
            Assert.IsFalse(hash.IsExist("sun"));
        }

        [TestMethod]
        public void RemoveTest()
        {
            hash.AddElement("sun");
            hash.RemoveElement("sun");
            Assert.IsFalse(hash.IsExist("sun"));
        }
    }
}
