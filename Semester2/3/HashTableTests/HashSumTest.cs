﻿namespace HashTableTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using HashNamespace;

    [TestClass]
    public class HashSumTest
    {
        private HashTable hash;

        [TestInitialize]
        public void Initialize()
        {
            hash = new HashFunctionSum(97);
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