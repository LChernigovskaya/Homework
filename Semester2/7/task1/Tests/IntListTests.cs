using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListNamespace;

namespace StackTests
{
    [TestClass]
    public class IntListTests
    {
        private MyList<int> list;

        [TestInitialize]
        public void Initialize()
        {
            list = new MyList<int>();
        }

        [TestMethod]
        public void ExistsTest()
        {
            Assert.IsFalse(list.Exists(7));
        }

        [TestMethod]
        public void AddToHeadTest()
        {
            list.AddToHead(6);
            Assert.IsTrue(list.Exists(6));
        }

        [TestMethod]
        public void AddToHeadAndReturnTest()
        {
            list.AddToHead(8);
            Assert.AreEqual(8, list.ReturnValue(0));
        }

        [TestMethod]
        public void ThreeElementAddToHeadTest()
        {
            list.AddToHead(8);
            list.AddToHead(6);
            list.AddToHead(0);
            Assert.AreEqual(list.ReturnValue(0), 0);
            Assert.AreEqual(list.ReturnValue(1), 6);
            Assert.AreEqual(list.ReturnValue(2), 8);
        }

        [TestMethod]
        public void AddToPositionTest()
        {
            list.AddToPosition(1, 0);
            Assert.AreEqual(list.ReturnValue(0), 1);
        }

        [TestMethod]
        public void SomeElementsAddToPositionTest()
        {
            list.AddToPosition(5, 0);
            list.AddToPosition(4, 1);
            list.AddToPosition(6, 1);
            Assert.AreEqual(5, list.ReturnValue(0));
            Assert.AreEqual(6, list.ReturnValue(1));
            Assert.AreEqual(4, list.ReturnValue(2));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddToPositionExceptionTest()
        {
            list.AddToPosition(4, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddThreeElementsToPositionTest()
        {
            list.AddToPosition(4, 0);
            list.AddToPosition(7, 1);
            list.AddToPosition(8, 10);
        }

        [TestMethod]
        public void RemoveElementTest()
        {
            list.AddToPosition(8, 0);
            list.AddToPosition(6, 0);
            list.RemoveElement(6);
            Assert.IsFalse(list.Exists(6));
            Assert.IsTrue(list.Exists(8));
        }

        [TestMethod]
        public void RemoveTheSameElements()
        {
            list.AddToPosition(6, 0);
            list.AddToPosition(7, 1);
            list.AddToPosition(6, 2);
            list.RemoveElement(6);
            Assert.IsTrue(list.Exists(6));
            Assert.AreEqual("7 6 ", list.PrintList());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RemoveFromEmptyList()
        {
            list.RemoveElement(9);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RemoveNonexistenElement()
        {
            list.AddToPosition(8, 0);
            list.RemoveElement(9);
        }

        [TestMethod]
        public void PrintTest()
        {
            list.AddToHead(9);
            list.AddToHead(0);
            list.AddToHead(89);
            list.AddToHead(5);
            Assert.AreEqual("5 89 0 9 ", list.PrintList());
        }

        [TestMethod]
        public void PrintTwoLinesTest()
        {
            list.AddToHead(0);
            list.AddToHead(87);
            Assert.AreEqual("87 0 ", list.PrintList());
            list.AddToHead(8);
            list.AddToHead(76);
            Assert.AreEqual("76 8 87 0 ", list.PrintList());
        }

        [TestMethod]
        public void PrintWithRemoveTest()
        {
            list.AddToPosition(7, 0);
            list.AddToPosition(8, 0);
            list.AddToPosition(6, 1);
            Assert.AreEqual("8 6 7 ", list.PrintList());
            list.RemoveElement(6);
            Assert.AreEqual("8 7 ", list.PrintList());
        }
    }
}
