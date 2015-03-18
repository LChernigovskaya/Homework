using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListNamespace;

namespace Tests
{
    [TestClass]
    public class ListTests
    {
        private List<int> list;

        [TestInitialize]
        public void Initialize()
        {
            list = new List<int>();
        }

        [TestMethod]
        public void AddTest()
        {
            list.AddTail(1);
            Assert.AreEqual(list.ReturnValue(0), 1);
        }

        [TestMethod]
        public void AddThreeElementsTest()
        {
            list.AddTail(1);
            list.AddTail(2);
            list.AddTail(3);
            Assert.AreEqual(1, list.ReturnValue(0));
            Assert.AreEqual(2, list.ReturnValue(1));
            Assert.AreEqual(3, list.ReturnValue(2));
        }

        [TestMethod]
        [ExpectedException(typeof(ListException))]
        public void EmptyListTest()
        {
            list.ReturnValue(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ListException))]
        public void BigIndexTest()
        {
            list.AddTail(8);
            list.ReturnValue(2);
        }
    }
}
