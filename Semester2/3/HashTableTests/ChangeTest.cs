﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashNamespace;

namespace HashTableTests
{
    [TestClass]
    public class ChangeTest
    {
        private HashTable hash;

        [TestInitialize]
        public void Initialize()
        {
            hash = new HashTable(97);
        }

        private int UserHashFunction(string inputString, int maxSize)
        {
            int hashf = 0;
            int length = inputString.Length;

            for (int i = 0; i < length; i++)
                hashf += inputString[i];

            return hashf % maxSize;
        }

        [TestMethod]
        public void Change()
        {
            hash.AddElement("cut");
            hash.AddElement("tuc");
            hash.ChangeHashFunction(UserHashFunction);
            Assert.IsTrue(hash.IsExist("cut"));
            Assert.IsTrue(hash.IsExist("tuc"));
        }

        [TestMethod]
        public void AddInChange()
        {
            hash.ChangeHashFunction(UserHashFunction);
            hash.AddElement("hello");
            Assert.IsTrue(hash.IsExist("hello"));
        }
    }
}
